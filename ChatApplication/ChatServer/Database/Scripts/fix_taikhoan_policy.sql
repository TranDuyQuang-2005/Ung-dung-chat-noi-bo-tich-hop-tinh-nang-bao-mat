--------------------------------------------------------------------------------
-- FIX TAIKHOAN_POLICY_FN ERROR
-- Chạy với user CHATAPPLICATION
--------------------------------------------------------------------------------

-- 1. Xóa policy sai (trỏ tới function không tồn tại)
BEGIN 
    DBMS_RLS.DROP_POLICY('CHATAPPLICATION','TAIKHOAN','TAIKHOAN_POLICY'); 
EXCEPTION WHEN OTHERS THEN 
    DBMS_OUTPUT.PUT_LINE('Policy TAIKHOAN_POLICY not found - OK');
END;
/

-- 2. Xóa các policy TAIKHOAN cũ để đảm bảo clean
BEGIN DBMS_RLS.DROP_POLICY('CHATAPPLICATION','TAIKHOAN','VPD_TAIKHOAN_SELECT'); EXCEPTION WHEN OTHERS THEN NULL; END;
/

-- 3. Tạo lại function VPD_TAIKHOAN_SELECT_FN
CREATE OR REPLACE FUNCTION VPD_TAIKHOAN_SELECT_FN(
    schema_name IN VARCHAR2, table_name IN VARCHAR2
) RETURN VARCHAR2 AS
    v_user_level NUMBER;
    v_username VARCHAR2(100);
BEGIN
    v_user_level := TO_NUMBER(NVL(SYS_CONTEXT('MAC_CTX', 'USER_LEVEL'), '1'));
    v_username := SYS_CONTEXT('MAC_CTX', 'USERNAME');
    -- Admin (level >= 4) thấy tất cả
    IF v_user_level >= 4 THEN RETURN '1=1'; END IF;
    -- User bình thường chỉ thấy user có level <= mình hoặc chính mình
    RETURN 'CLEARANCELEVEL <= ' || v_user_level || ' OR MATK = ''' || v_username || ''' OR TENTK = ''' || v_username || '''';
END;
/

-- 4. Thêm lại VPD policy đúng
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'CHATAPPLICATION', 
        object_name => 'TAIKHOAN',
        policy_name => 'VPD_TAIKHOAN_SELECT', 
        function_schema => 'CHATAPPLICATION',
        policy_function => 'VPD_TAIKHOAN_SELECT_FN', 
        statement_types => 'SELECT', 
        enable => TRUE
    );
    DBMS_OUTPUT.PUT_LINE('VPD_TAIKHOAN_SELECT policy added successfully');
EXCEPTION WHEN OTHERS THEN
    DBMS_OUTPUT.PUT_LINE('Error adding policy: ' || SQLERRM);
END;
/

-- 5. Xóa record sai trong ADMIN_POLICY nếu có
DELETE FROM ADMIN_POLICY WHERE POLICY_NAME = 'TAIKHOAN_POLICY';
DELETE FROM ADMIN_POLICY WHERE POLICY_NAME = 'VPD_TAIKHOAN_SELECT' AND POLICY_TYPE = 'VPD';

-- 6. Thêm lại record đúng
INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, POLICY_FUNCTION, STATEMENT_TYPES, IS_ENABLED)
VALUES('VPD_TAIKHOAN_SELECT', 'VPD', 'TAIKHOAN', 
       'Ẩn thông tin tài khoản có clearance cao hơn user hiện tại (Admin bypass)', 
       'VPD_TAIKHOAN_SELECT_FN', 'SELECT', 1);

COMMIT;

SELECT 'Fix completed!' AS STATUS FROM DUAL;
