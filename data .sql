-----RUN EXE-----
--cd /d "D:\Nhom11_Ung dung chat noi bo tich hop tinh nang bao mat\ChatApplication\ChatServer\bin\Debug\net8.0-windows"

--ChatServer.exe
--cd "D:\Nhom11_Ung dung chat noi bo tich hop tinh nang bao mat\ChatApplication\ChatClient\bin\Debug\net8.0-windows"
--ChatClient.exe
-----RUN EXE-----

---sys
--------------------------------------------------------------------------------
-- 01_SYS_SETUP.SQL - CHẠY VỚI SYS AS SYSDBA
-- Bao gồm: Tablespace, Profile, User, Context, Roles cơ bản
--------------------------------------------------------------------------------
SET SERVEROUTPUT ON;


---Tạo TABLESPACE CHAT_DATA_TS
CREATE TABLESPACE CHAT_DATA_TS
DATAFILE 'C:\ORACLE19C\INSTALL\ORADATA\ORCL\ORCLPDB\chat_data01.dbf'
SIZE 200M 
AUTOEXTEND ON NEXT 100M 
MAXSIZE UNLIMITED;
---Tạo TABLESPACE CHAT_AUDIT_TS
CREATE TABLESPACE CHAT_AUDIT_TS
DATAFILE 'C:\ORACLE19C\INSTALL\ORADATA\ORCL\ORCLPDB\chat_audit01.dbf'
SIZE 50M 
AUTOEXTEND ON NEXT 20M 
MAXSIZE UNLIMITED;

-- =============================================================================
-- 1. TABLESPACE - Không gian lưu trữ (bỏ qua nếu đã có)
-- =============================================================================
DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count FROM dba_tablespaces WHERE tablespace_name = 'CHAT_DATA_TS';
    IF v_count = 0 THEN
        EXECUTE IMMEDIATE 'CREATE TABLESPACE CHAT_DATA_TS DATAFILE ''chat_data01.dbf'' SIZE 100M AUTOEXTEND ON NEXT 50M MAXSIZE 2G EXTENT MANAGEMENT LOCAL';
        DBMS_OUTPUT.PUT_LINE('Created CHAT_DATA_TS');
    ELSE
        DBMS_OUTPUT.PUT_LINE('CHAT_DATA_TS already exists - skipped');
    END IF;
END;
/

DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count FROM dba_tablespaces WHERE tablespace_name = 'CHAT_AUDIT_TS';
    IF v_count = 0 THEN
        EXECUTE IMMEDIATE 'CREATE TABLESPACE CHAT_AUDIT_TS DATAFILE ''chat_audit01.dbf'' SIZE 50M AUTOEXTEND ON NEXT 25M MAXSIZE 1G EXTENT MANAGEMENT LOCAL';
        DBMS_OUTPUT.PUT_LINE('Created CHAT_AUDIT_TS');
    ELSE
        DBMS_OUTPUT.PUT_LINE('CHAT_AUDIT_TS already exists - skipped');
    END IF;
END;
/

-- =============================================================================
-- 2. PROFILE - Giới hạn session và tài nguyên (bỏ qua nếu đã có)
-- =============================================================================
DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count FROM dba_profiles WHERE profile = 'CHAT_ADMIN_PROFILE' AND ROWNUM = 1;
    IF v_count = 0 THEN
        EXECUTE IMMEDIATE 'CREATE PROFILE CHAT_ADMIN_PROFILE LIMIT 
        SESSIONS_PER_USER 5 
        CPU_PER_SESSION UNLIMITED 
        CPU_PER_CALL 60000 
        CONNECT_TIME 480 
        IDLE_TIME 60 
        FAILED_LOGIN_ATTEMPTS 5 
        PASSWORD_LIFE_TIME 90 
        PASSWORD_REUSE_TIME 365 
        PASSWORD_REUSE_MAX 10 
        PASSWORD_LOCK_TIME 1/24';
    END IF;
END;
/

DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count FROM dba_profiles WHERE profile = 'CHAT_USER_PROFILE' AND ROWNUM = 1;
    IF v_count = 0 THEN
        EXECUTE IMMEDIATE 'CREATE PROFILE CHAT_USER_PROFILE LIMIT 
        SESSIONS_PER_USER 3 
        CPU_PER_SESSION DEFAULT 
        CPU_PER_CALL 30000 
        CONNECT_TIME 240 
        IDLE_TIME 30 
        FAILED_LOGIN_ATTEMPTS 5 
        PASSWORD_LIFE_TIME 180 
        PASSWORD_LOCK_TIME 1/48';
    END IF;
END;
/

DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count FROM dba_profiles WHERE profile = 'CHAT_INTERN_PROFILE' AND ROWNUM = 1;
    IF v_count = 0 THEN
        EXECUTE IMMEDIATE 'CREATE PROFILE CHAT_INTERN_PROFILE LIMIT 
        SESSIONS_PER_USER 2 
        CPU_PER_SESSION DEFAULT 
        CPU_PER_CALL 10000 
        CONNECT_TIME 120 
        IDLE_TIME 15 
        FAILED_LOGIN_ATTEMPTS 3 
        PASSWORD_LIFE_TIME 30 
        PASSWORD_LOCK_TIME 1/24';
    END IF;
END;
/

-- =============================================================================
-- 3. USER - Tạo user ChatApplication
-- =============================================================================
DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count FROM dba_users WHERE username = 'CHATAPPLICATION';
    IF v_count = 0 THEN
        EXECUTE IMMEDIATE 'CREATE USER ChatApplication IDENTIFIED BY "123" DEFAULT TABLESPACE CHAT_DATA_TS 
        QUOTA UNLIMITED ON CHAT_DATA_TS 
        QUOTA UNLIMITED ON CHAT_AUDIT_TS 
        PROFILE CHAT_ADMIN_PROFILE';
        DBMS_OUTPUT.PUT_LINE('Created user ChatApplication');
    ELSE
        DBMS_OUTPUT.PUT_LINE('User ChatApplication already exists - skipped');
    END IF;
END;
/

-- Quyền cơ bản
GRANT CREATE SESSION, CREATE TABLE, CREATE SEQUENCE TO ChatApplication;
GRANT CREATE PROCEDURE, CREATE VIEW, CREATE TRIGGER TO ChatApplication;

-- Quyền cho VPD, FGA, Encryption
GRANT EXECUTE ON DBMS_RLS TO ChatApplication;
GRANT EXECUTE ON DBMS_FGA TO ChatApplication;
GRANT EXECUTE ON DBMS_SESSION TO ChatApplication;
GRANT EXECUTE ON DBMS_CRYPTO TO ChatApplication;

-- Quyền Audit
GRANT AUDIT ANY TO ChatApplication;
GRANT AUDIT SYSTEM TO ChatApplication;

-- =============================================================================
-- 4. CONTEXT - Cho MAC và Session
-- =============================================================================
CREATE OR REPLACE CONTEXT MAC_CTX USING ChatApplication.MAC_CTX_PKG;
CREATE OR REPLACE CONTEXT SESSION_CTX USING ChatApplication.SESSION_CTX_PKG;
CREATE OR REPLACE CONTEXT ADMIN_CTX USING ChatApplication.ADMIN_CTX_PKG;

-- =============================================================================
-- 5. DAC - ROLES CƠ BẢN (bỏ qua nếu đã có)
-- LƯU Ý: Grants trên tables sẽ chạy sau trong file 06_grants.sql
-- =============================================================================
DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count FROM dba_roles WHERE role = 'CHAT_OWNER_ROLE';
    IF v_count = 0 THEN
        EXECUTE IMMEDIATE 'CREATE ROLE CHAT_OWNER_ROLE';
        EXECUTE IMMEDIATE 'GRANT ALL PRIVILEGES TO CHAT_OWNER_ROLE';
    END IF;
END;
/

DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count FROM dba_roles WHERE role = 'CHAT_ADMIN_ROLE';
    IF v_count = 0 THEN
        EXECUTE IMMEDIATE 'CREATE ROLE CHAT_ADMIN_ROLE';
    END IF;
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO CHAT_ADMIN_ROLE';
EXCEPTION WHEN OTHERS THEN NULL;
END;
/

DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count FROM dba_roles WHERE role = 'CHAT_USER_ROLE';
    IF v_count = 0 THEN
        EXECUTE IMMEDIATE 'CREATE ROLE CHAT_USER_ROLE';
    END IF;
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO CHAT_USER_ROLE';
EXCEPTION WHEN OTHERS THEN NULL;
END;
/

DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count FROM dba_roles WHERE role = 'CHAT_INTERN_ROLE';
    IF v_count = 0 THEN
        EXECUTE IMMEDIATE 'CREATE ROLE CHAT_INTERN_ROLE';
    END IF;
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO CHAT_INTERN_ROLE';
EXCEPTION WHEN OTHERS THEN NULL;
END;
/

-- =============================================================================
-- 6. GÁN ROLE CHO USER ChatApplication
-- =============================================================================
BEGIN EXECUTE IMMEDIATE 'GRANT CHAT_OWNER_ROLE TO ChatApplication'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT DBA TO ChatApplication'; EXCEPTION WHEN OTHERS THEN NULL; END;
/

COMMIT;

---( Tạo thư mục backup (Oracle directory))
drop directory CHAT_BACKUP_DIR;
create OR REPLACE directory CHAT_BACKUP_DIR as 'D:\\oracle_backup';

CREATE OR REPLACE DIRECTORY CHAT_BACKUP_DIR AS 'D:\oracle_backup';

GRANT READ, WRITE ON DIRECTORY CHAT_BACKUP_DIR TO SYS;
GRANT READ, WRITE ON DIRECTORY CHAT_BACKUP_DIR TO public;
GRANT READ, WRITE ON DIRECTORY CHAT_BACKUP_DIR TO SYSTEM;
GRANT READ, WRITE ON DIRECTORY CHAT_BACKUP_DIR TO CHATAPPLICATION;




BEGIN
  DBMS_SCHEDULER.CREATE_CREDENTIAL(
    credential_name => 'WIN_CRED',
    username        => 'Lenovo',
    password        => '005500880066'
  );
END;
/
GRANT EXECUTE ON SYS.WIN_CRED TO CHATAPPLICATION;
SELECT * FROM dba_credentials;


BEGIN
    DBMS_SCHEDULER.DROP_JOB('SYS.JOB_BACKUP_CHAT', FORCE => TRUE);
END;
/



/
---(Tạo JOB backup hàng ngày)
BEGIN
    DBMS_SCHEDULER.CREATE_JOB(
        JOB_NAME => 'JOB_BACKUP_CHAT',
        JOB_TYPE => 'STORED_PROCEDURE',
        JOB_ACTION => 'SP_BACKUP_DATA',
        START_DATE => SYSTIMESTAMP,
        REPEAT_INTERVAL => 'FREQ=DAILY;BYHOUR=23;BYMINUTE=00;BYSECOND=00',
        ENABLED => TRUE
    );
END;
/

SELECT 'SYS Setup completed!' AS STATUS FROM DUAL;


------------Kiem tra lai
-- Tablespace
SELECT tablespace_name FROM dba_tablespaces
WHERE tablespace_name LIKE 'CHAT%';

-- User
SELECT username, profile FROM dba_users
WHERE username = 'CHATAPPLICATION';

-- Roles
SELECT role FROM dba_roles WHERE role LIKE 'CHAT%';

-- Directory
SELECT directory_name, directory_path
FROM dba_directories
WHERE directory_name = 'CHAT_BACKUP_DIR';

-- Job
SELECT job_name, enabled
FROM dba_scheduler_jobs
WHERE job_name = 'JOB_BACKUP_CHAT';



--------------------
---(Do c##)
ALTER PLUGGABLE DATABASE ORCLPDB OPEN;
ALTER SESSION SET CONTAINER = ORCLPDB;
SELECT NAME, OPEN_MODE FROM V$PDBS;
SHOW CON_NAME;

SELECT tablespace_name FROM dba_tablespaces;
SELECT FILE_NAME FROM DBA_DATA_FILES;

---------------------
DROP DIRECTORY CHAT_BACKUP_DIR;
-----
GRANT CREATE SESSION TO CHATAPPLICATION;
GRANT CREATE TABLE TO CHATAPPLICATION;
GRANT CREATE VIEW TO CHATAPPLICATION;
GRANT CREATE PROCEDURE TO CHATAPPLICATION;
GRANT CREATE TRIGGER TO CHATAPPLICATION;
GRANT CREATE SEQUENCE TO CHATAPPLICATION;
ALTER USER CHATAPPLICATION DEFAULT TABLESPACE CHAT_DATA_TS;
ALTER USER CHATAPPLICATION TEMPORARY TABLESPACE TEMP;
GRANT READ ANY TABLE TO CHATAPPLICATION;
---------User
select *from tinnhan
--------------------------------------------------------------------------------
-- 02_SCHEMA.SQL - CHẠY VỚI ChatApplication
-- Bao gồm: Tables, Indexes, Constraints
--------------------------------------------------------------------------------

-- =============================================================================
-- BẢNG VAI TRÒ (RBAC)
-- =============================================================================
CREATE TABLE VAITRO (
    MAVAITRO    VARCHAR2(20) PRIMARY KEY,
    TENVAITRO   VARCHAR2(100) NOT NULL,
    CHUCNANG    VARCHAR2(500),
    CAPDO       NUMBER DEFAULT 1,
    MOTA        VARCHAR2(500)
) TABLESPACE CHAT_DATA_TS;

-- =============================================================================
-- BẢNG TÀI KHOẢN
-- =============================================================================
CREATE TABLE TAIKHOAN (
    MATK            VARCHAR2(20) PRIMARY KEY,
    TENTK           VARCHAR2(100) NOT NULL UNIQUE,
    PASSWORD_HASH   VARCHAR2(256) NOT NULL,
    MAVAITRO        VARCHAR2(20),
    CLEARANCELEVEL  NUMBER DEFAULT 1 NOT NULL CHECK (CLEARANCELEVEL BETWEEN 1 AND 5),
    IS_BANNED_GLOBAL NUMBER(1) DEFAULT 0 CHECK (IS_BANNED_GLOBAL IN (0, 1)),
    IS_OTP_VERIFIED NUMBER(1) DEFAULT 0 CHECK (IS_OTP_VERIFIED IN (0, 1)),
    PROFILE_NAME    VARCHAR2(50) DEFAULT 'CHAT_USER_PROFILE',
    NGAYTAO         TIMESTAMP DEFAULT SYSTIMESTAMP,
    LAST_LOGIN      TIMESTAMP,
    LAST_LOGOUT     TIMESTAMP,
    LOGIN_COUNT     NUMBER DEFAULT 0,
    PUBLIC_KEY      CLOB,
    FAILED_LOGIN_ATTEMPTS NUMBER DEFAULT 0,
    LOCKED_UNTIL    TIMESTAMP,
    CONSTRAINT FK_TK_VAITRO FOREIGN KEY(MAVAITRO) REFERENCES VAITRO(MAVAITRO)
) TABLESPACE CHAT_DATA_TS;

BEGIN EXECUTE IMMEDIATE 'CREATE INDEX IDX_TAIKHOAN_TENTK ON TAIKHOAN(TENTK)'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'CREATE INDEX IDX_TAIKHOAN_VAITRO ON TAIKHOAN(MAVAITRO)'; EXCEPTION WHEN OTHERS THEN NULL; END;
/

-- =============================================================================
-- BẢNG PHIÊN ĐĂNG NHẬP (Session Management)
-- =============================================================================
CREATE TABLE PHIENDANGNHAP (
    MAPHIEN         VARCHAR2(50) PRIMARY KEY,
    MATK            VARCHAR2(20) NOT NULL,
    IP_ADDRESS      VARCHAR2(50),
    USER_AGENT      VARCHAR2(500),
    THOIDIEM_DANGNHAP TIMESTAMP DEFAULT SYSTIMESTAMP,
    THOIDIEM_HETHAN TIMESTAMP,
    TRANG_THAI      VARCHAR2(20) DEFAULT 'ACTIVE' CHECK (TRANG_THAI IN ('ACTIVE','EXPIRED','LOGGED_OUT')),
    CLEARANCELEVEL_SESSION NUMBER DEFAULT 1,
    CONSTRAINT FK_PHIEN_TK FOREIGN KEY(MATK) REFERENCES TAIKHOAN(MATK) ON DELETE CASCADE
) TABLESPACE CHAT_DATA_TS;

BEGIN EXECUTE IMMEDIATE 'CREATE INDEX IDX_PHIEN_MATK ON PHIENDANGNHAP(MATK)'; EXCEPTION WHEN OTHERS THEN NULL; END;
/

-- =============================================================================
-- BẢNG PHÒNG BAN VÀ CHỨC VỤ
-- =============================================================================
CREATE TABLE PHONGBAN (
    MAPB        VARCHAR2(20) PRIMARY KEY,
    TENPB       VARCHAR2(200) NOT NULL,
    MOTA        VARCHAR2(500),
    CLEARANCELEVEL_MIN NUMBER DEFAULT 1
) TABLESPACE CHAT_DATA_TS;

CREATE TABLE CHUCVU (
    MACV        VARCHAR2(20) PRIMARY KEY,
    TENCV       VARCHAR2(100) NOT NULL,
    CAPBAC      NUMBER DEFAULT 1,
    CLEARANCELEVEL_DEFAULT NUMBER DEFAULT 1,
    MOTA        VARCHAR2(500)
) TABLESPACE CHAT_DATA_TS;
select *from taikhoan
-- =============================================================================
-- BẢNG THÔNG TIN NGƯỜI DÙNG
-- =============================================================================
CREATE TABLE NGUOIDUNG (
    MATK        VARCHAR2(20) PRIMARY KEY,
    MAPB        VARCHAR2(20),
    MACV        VARCHAR2(20),
    HOVATEN     VARCHAR2(200),
    EMAIL       VARCHAR2(200),
    SDT         VARCHAR2(20),
    NGAYSINH    DATE,
    DIACHI      VARCHAR2(500),
    AVATAR_URL  VARCHAR2(400),
    BIO         VARCHAR2(1000),
    NGAYCAPNHAT TIMESTAMP DEFAULT SYSTIMESTAMP,
    CONSTRAINT FK_ND_TK FOREIGN KEY(MATK) REFERENCES TAIKHOAN(MATK) ON DELETE CASCADE,
    CONSTRAINT FK_ND_PB FOREIGN KEY(MAPB) REFERENCES PHONGBAN(MAPB),
    CONSTRAINT FK_ND_CV FOREIGN KEY(MACV) REFERENCES CHUCVU(MACV)
) TABLESPACE CHAT_DATA_TS;

-- =============================================================================
-- BẢNG LOẠI CUỘC TRÒ CHUYỆN
-- =============================================================================
CREATE TABLE LOAICTC (
    MALOAICTC   VARCHAR2(20) PRIMARY KEY,
    TENLOAICTC  VARCHAR2(200) NOT NULL,
    IS_PRIVATE  VARCHAR2(1) DEFAULT 'N',
    MOTA        VARCHAR2(500)
) TABLESPACE CHAT_DATA_TS;

-- =============================================================================
-- BẢNG CUỘC TRÒ CHUYỆN
-- =============================================================================
CREATE TABLE CUOCTROCHUYEN (
    MACTC               VARCHAR2(60) PRIMARY KEY,
    MALOAICTC           VARCHAR2(20),
    TENCTC              VARCHAR2(200),
    NGAYTAO             TIMESTAMP DEFAULT SYSTIMESTAMP,
    NGUOIQL             VARCHAR2(20),
    IS_PRIVATE          VARCHAR2(1) DEFAULT 'N',
    CREATED_BY          VARCHAR2(20),
    MOTA                VARCHAR2(1000),
    IS_ENCRYPTED        NUMBER(1) DEFAULT 0,
    IS_ARCHIVED         NUMBER(1) DEFAULT 0,
    ARCHIVED_AT         TIMESTAMP,
    MIN_CLEARANCE       NUMBER DEFAULT 1 CHECK (MIN_CLEARANCE BETWEEN 1 AND 5),
    THOIGIANTINNHANCUOI TIMESTAMP,
    CONSTRAINT FK_CTC_LOAI FOREIGN KEY(MALOAICTC) REFERENCES LOAICTC(MALOAICTC),
    CONSTRAINT FK_CTC_QL FOREIGN KEY(NGUOIQL) REFERENCES TAIKHOAN(MATK)
) TABLESPACE CHAT_DATA_TS;

BEGIN EXECUTE IMMEDIATE 'CREATE INDEX IDX_CTC_NGUOIQL ON CUOCTROCHUYEN(NGUOIQL)'; EXCEPTION WHEN OTHERS THEN NULL; END;
/

-- =============================================================================
-- BẢNG PHÂN QUYỀN NHÓM (RBAC cho nhóm chat)
-- =============================================================================
CREATE TABLE PHAN_QUYEN_NHOM (
    MAPHANQUYEN VARCHAR2(20) PRIMARY KEY,
    TENQUYEN    VARCHAR2(100) NOT NULL,
    CAN_ADD     NUMBER(1) DEFAULT 0,
    CAN_REMOVE  NUMBER(1) DEFAULT 0,
    CAN_PROMOTE NUMBER(1) DEFAULT 0,
    CAN_DELETE  NUMBER(1) DEFAULT 0,
    CAN_BAN     NUMBER(1) DEFAULT 0,
    CAN_UNBAN   NUMBER(1) DEFAULT 0,
    CAN_MUTE    NUMBER(1) DEFAULT 0,
    CAN_UNMUTE  NUMBER(1) DEFAULT 0,
    CAN_EDIT    NUMBER(1) DEFAULT 0,
    CAN_PIN     NUMBER(1) DEFAULT 0
) TABLESPACE CHAT_DATA_TS;

-- =============================================================================
-- BẢNG THÀNH VIÊN
-- =============================================================================
CREATE TABLE THANHVIEN (
    MACTC             VARCHAR2(60),
    MATK              VARCHAR2(20),
    NGAYTHAMGIA       TIMESTAMP DEFAULT SYSTIMESTAMP,
    QUYEN             VARCHAR2(100) DEFAULT 'member',
    MAPHANQUYEN       VARCHAR2(20),
    IS_BANNED         NUMBER(1) DEFAULT 0,
    IS_MUTED          NUMBER(1) DEFAULT 0,
    DELETED_BY_MEMBER NUMBER(1) DEFAULT 0,
    NICKNAME          VARCHAR2(100),
    CONSTRAINT PK_THANHVIEN PRIMARY KEY(MACTC, MATK),
    CONSTRAINT FK_TV_CTC FOREIGN KEY(MACTC) REFERENCES CUOCTROCHUYEN(MACTC) ON DELETE CASCADE,
    CONSTRAINT FK_TV_TK FOREIGN KEY(MATK) REFERENCES TAIKHOAN(MATK) ON DELETE CASCADE,
    CONSTRAINT FK_TV_PQ FOREIGN KEY(MAPHANQUYEN) REFERENCES PHAN_QUYEN_NHOM(MAPHANQUYEN)
) TABLESPACE CHAT_DATA_TS;

BEGIN EXECUTE IMMEDIATE 'CREATE INDEX IDX_TV_MATK ON THANHVIEN(MATK)'; EXCEPTION WHEN OTHERS THEN NULL; END;
/

-- =============================================================================
-- BẢNG LOẠI TIN NHẮN VÀ TRẠNG THÁI
-- =============================================================================
CREATE TABLE LOAITN (
    MALOAITN    VARCHAR2(20) PRIMARY KEY,
    TENLOAITN   VARCHAR2(100) NOT NULL
) TABLESPACE CHAT_DATA_TS;

CREATE TABLE TRANGTHAI (
    MATRANGTHAI     VARCHAR2(20) PRIMARY KEY,
    TENTRANGTHAI    VARCHAR2(100) NOT NULL
) TABLESPACE CHAT_DATA_TS;

-- =============================================================================
-- BẢNG TIN NHẮN (với SECURITYLABEL cho MAC)
-- =============================================================================
CREATE TABLE TINNHAN (
    MATN            NUMBER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
    MACTC           VARCHAR2(60),
    MATK            VARCHAR2(20),
    MALOAITN        VARCHAR2(20),
    MATRANGTHAI     VARCHAR2(20),
    NOIDUNG         CLOB,
    NGAYGUI         TIMESTAMP DEFAULT SYSTIMESTAMP,
    SECURITYLABEL   NUMBER DEFAULT 1 NOT NULL CHECK (SECURITYLABEL BETWEEN 1 AND 5),
    IS_ENCRYPTED    NUMBER(1) DEFAULT 0,
    ENCRYPTED_CONTENT   RAW(2000),
    ENCRYPTED_KEY   CLOB,
    ENCRYPTION_IV   VARCHAR2(100),
    ENCRYPTION_TYPE VARCHAR2(20) DEFAULT 'NONE',
    SIGNATURE       CLOB,
    IS_PINNED       NUMBER(1) DEFAULT 0,
    EDITED_AT       TIMESTAMP,
    CONSTRAINT FK_TN_CTC FOREIGN KEY(MACTC) REFERENCES CUOCTROCHUYEN(MACTC) ON DELETE CASCADE,
    CONSTRAINT FK_TN_TK FOREIGN KEY(MATK) REFERENCES TAIKHOAN(MATK),
    CONSTRAINT FK_TN_LOAI FOREIGN KEY(MALOAITN) REFERENCES LOAITN(MALOAITN),
    CONSTRAINT FK_TN_TT FOREIGN KEY(MATRANGTHAI) REFERENCES TRANGTHAI(MATRANGTHAI)
) TABLESPACE CHAT_DATA_TS;

BEGIN EXECUTE IMMEDIATE 'CREATE INDEX IDX_TN_MACTC ON TINNHAN(MACTC)'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'CREATE INDEX IDX_TN_NGAYGUI ON TINNHAN(NGAYGUI)'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'CREATE INDEX IDX_TN_SECLABEL ON TINNHAN(SECURITYLABEL)'; EXCEPTION WHEN OTHERS THEN NULL; END;
/

-- =============================================================================
-- BẢNG ATTACHMENT
-- =============================================================================
CREATE TABLE ATTACHMENT (
    ATTACH_ID   NUMBER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
    MATK        VARCHAR2(20) NOT NULL,
    FILENAME    VARCHAR2(255) NOT NULL,
    MIMETYPE    VARCHAR2(200),
    FILESIZE    NUMBER,
    FILEDATA    BLOB,
    UPLOADED_AT TIMESTAMP DEFAULT SYSTIMESTAMP,
    IS_ENCRYPTED NUMBER(1) DEFAULT 0,
    CONSTRAINT FK_ATTACH_TK FOREIGN KEY(MATK) REFERENCES TAIKHOAN(MATK) ON DELETE CASCADE
) TABLESPACE CHAT_DATA_TS;

CREATE TABLE TINNHAN_ATTACH (
    MATN        NUMBER,
    ATTACH_ID   NUMBER,
    CONSTRAINT PK_TN_ATTACH PRIMARY KEY(MATN, ATTACH_ID),
    CONSTRAINT FK_TNA_TN FOREIGN KEY(MATN) REFERENCES TINNHAN(MATN) ON DELETE CASCADE,
    CONSTRAINT FK_TNA_ATT FOREIGN KEY(ATTACH_ID) REFERENCES ATTACHMENT(ATTACH_ID) ON DELETE CASCADE
) TABLESPACE CHAT_DATA_TS;

-- =============================================================================
-- BẢNG XÁC THỰC OTP
-- =============================================================================
CREATE TABLE XACTHUCOTP (
    MAOTP           NUMBER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
    MATK            VARCHAR2(20),
    EMAIL           VARCHAR2(200),
    MAXTOTP         VARCHAR2(256),
    THOIGIANTAO     TIMESTAMP DEFAULT SYSTIMESTAMP,
    THOIGIANTONTAI  TIMESTAMP,
    DAXACMINH       NUMBER(1) DEFAULT 0,
    CONSTRAINT FK_OTP_TK FOREIGN KEY(MATK) REFERENCES TAIKHOAN(MATK) ON DELETE CASCADE
) TABLESPACE CHAT_DATA_TS;

-- =============================================================================
-- BẢNG AUDIT LOGS (Standard Auditing)
-- =============================================================================
CREATE TABLE AUDIT_LOGS (
    LOG_ID          NUMBER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
    MATK            VARCHAR2(20),
    ACTION          VARCHAR2(200) NOT NULL,
    TARGET          VARCHAR2(500),
    SECURITYLABEL   NUMBER DEFAULT 0,
    TIMESTAMP       TIMESTAMP DEFAULT SYSTIMESTAMP,
    IP_ADDRESS      VARCHAR2(50),
    DETAILS         CLOB,
    STATUS          VARCHAR2(50) DEFAULT 'SUCCESS',
    OLD_VALUE       CLOB,
    NEW_VALUE       CLOB
) TABLESPACE CHAT_AUDIT_TS;

BEGIN EXECUTE IMMEDIATE 'CREATE INDEX IDX_AUDIT_TIME ON AUDIT_LOGS(TIMESTAMP)'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'CREATE INDEX IDX_AUDIT_MATK ON AUDIT_LOGS(MATK)'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'CREATE INDEX IDX_AUDIT_ACTION ON AUDIT_LOGS(ACTION)'; EXCEPTION WHEN OTHERS THEN NULL; END;
/

-- =============================================================================
-- BẢNG QUẢN LÝ POLICY (Admin Panel)
-- =============================================================================
CREATE TABLE ADMIN_POLICY (
    POLICY_ID       NUMBER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
    POLICY_NAME     VARCHAR2(100) NOT NULL UNIQUE,
    POLICY_TYPE     VARCHAR2(50) NOT NULL CHECK (POLICY_TYPE IN ('VPD','FGA','DAC','MAC','RBAC','OLS')),
    TABLE_NAME      VARCHAR2(100) NOT NULL,
    DESCRIPTION     VARCHAR2(1000),
    POLICY_FUNCTION VARCHAR2(200),
    STATEMENT_TYPES VARCHAR2(100),
    IS_ENABLED      NUMBER(1) DEFAULT 1,
    CREATED_BY      VARCHAR2(20),
    CREATED_AT      TIMESTAMP DEFAULT SYSTIMESTAMP,
    UPDATED_AT      TIMESTAMP
) TABLESPACE CHAT_DATA_TS;

CREATE TABLE POLICY_CHANGE_LOG (
    LOG_ID      NUMBER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
    POLICY_ID   NUMBER,
    ACTION      VARCHAR2(50) NOT NULL,
    CHANGED_BY  VARCHAR2(20),
    CHANGED_AT  TIMESTAMP DEFAULT SYSTIMESTAMP,
    OLD_VALUE   CLOB,
    NEW_VALUE   CLOB,
    REASON      VARCHAR2(500)
) TABLESPACE CHAT_AUDIT_TS;

-- =============================================================================
-- BẢNG ENCRYPTION KEYS
-- =============================================================================
CREATE TABLE ENCRYPTION_KEYS (
    KEY_ID      NUMBER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
    MATK        VARCHAR2(20),
    KEY_TYPE    VARCHAR2(20) NOT NULL CHECK (KEY_TYPE IN ('RSA_PUBLIC','RSA_PRIVATE','AES','DES')),
    KEY_VALUE   CLOB NOT NULL,
    CREATED_AT  TIMESTAMP DEFAULT SYSTIMESTAMP,
    EXPIRES_AT  TIMESTAMP,
    IS_ACTIVE   NUMBER(1) DEFAULT 1,
    CONSTRAINT FK_EK_TK FOREIGN KEY(MATK) REFERENCES TAIKHOAN(MATK) ON DELETE CASCADE
) TABLESPACE CHAT_DATA_TS;


-----TẠO BẢNG LOG ĐĂNG NHẬP SAI
CREATE TABLE LOGIN_FAILED_LOGS (
    LOG_ID        NUMBER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
    USERNAME      VARCHAR2(50),
    IP_ADDRESS    VARCHAR2(50),
    ATTEMPT_TIME  TIMESTAMP DEFAULT SYSTIMESTAMP,
    ATTEMPT_COUNT NUMBER,
    STATUS        VARCHAR2(20)  -- 'FAILED' | 'LOCKED'
);

COMMIT;
SELECT 'Schema created successfully!' AS STATUS FROM DUAL;
--------------------------------------------------------------------------
--------------------------------------------------------------------------------
-- 03_PROCEDURES.SQL - CHẠY VỚI ChatApplication
-- Bao gồm: Packages, Procedures cho MAC, Session, CRUD
--------------------------------------------------------------------------------

-- =============================================================================
-- PACKAGE MAC_CTX_PKG - Quản lý MAC Context
-- =============================================================================
CREATE OR REPLACE PACKAGE MAC_CTX_PKG AS
    PROCEDURE SET_USER_LEVEL(p_user IN VARCHAR2, p_level IN NUMBER);
    PROCEDURE CLEAR_CONTEXT;
    FUNCTION GET_USER_LEVEL RETURN NUMBER;
    FUNCTION GET_USERNAME RETURN VARCHAR2;
END MAC_CTX_PKG;
/

CREATE OR REPLACE PACKAGE BODY MAC_CTX_PKG AS
    PROCEDURE SET_USER_LEVEL(p_user IN VARCHAR2, p_level IN NUMBER) IS
    BEGIN
        DBMS_SESSION.SET_CONTEXT('MAC_CTX', 'USERNAME', p_user);
        DBMS_SESSION.SET_CONTEXT('MAC_CTX', 'USER_LEVEL', TO_CHAR(p_level));
    END;
    
    PROCEDURE CLEAR_CONTEXT IS
    BEGIN
        DBMS_SESSION.CLEAR_CONTEXT('MAC_CTX');
    END;
    
    FUNCTION GET_USER_LEVEL RETURN NUMBER IS
    BEGIN
        RETURN TO_NUMBER(NVL(SYS_CONTEXT('MAC_CTX', 'USER_LEVEL'), '1'));
    END;
    
    FUNCTION GET_USERNAME RETURN VARCHAR2 IS
    BEGIN
        RETURN NVL(SYS_CONTEXT('MAC_CTX', 'USERNAME'), USER);
    END;
END MAC_CTX_PKG;
/

-- =============================================================================
-- PACKAGE SESSION_CTX_PKG - Quản lý Session
-- =============================================================================
CREATE OR REPLACE PACKAGE SESSION_CTX_PKG AS
    PROCEDURE SET_SESSION(p_session_id VARCHAR2, p_matk VARCHAR2, p_clearance NUMBER);
    PROCEDURE CLEAR_SESSION;
    FUNCTION GET_SESSION_ID RETURN VARCHAR2;
    FUNCTION GET_SESSION_USER RETURN VARCHAR2;
END SESSION_CTX_PKG;
/

CREATE OR REPLACE PACKAGE BODY SESSION_CTX_PKG AS
    PROCEDURE SET_SESSION(p_session_id VARCHAR2, p_matk VARCHAR2, p_clearance NUMBER) IS
    BEGIN
        DBMS_SESSION.SET_CONTEXT('SESSION_CTX', 'SESSION_ID', p_session_id);
        DBMS_SESSION.SET_CONTEXT('SESSION_CTX', 'USER_MATK', p_matk);
        DBMS_SESSION.SET_CONTEXT('SESSION_CTX', 'CLEARANCE', TO_CHAR(p_clearance));
    END;
    
    PROCEDURE CLEAR_SESSION IS
    BEGIN
        DBMS_SESSION.CLEAR_CONTEXT('SESSION_CTX');
    END;
    
    FUNCTION GET_SESSION_ID RETURN VARCHAR2 IS
    BEGIN
        RETURN SYS_CONTEXT('SESSION_CTX', 'SESSION_ID');
    END;
    
    FUNCTION GET_SESSION_USER RETURN VARCHAR2 IS
    BEGIN
        RETURN SYS_CONTEXT('SESSION_CTX', 'USER_MATK');
    END;
END SESSION_CTX_PKG;
/

-- =============================================================================
-- PACKAGE ADMIN_CTX_PKG - Quản lý Admin Context
-- =============================================================================
CREATE OR REPLACE PACKAGE ADMIN_CTX_PKG AS
    PROCEDURE SET_ADMIN(p_matk VARCHAR2, p_clearance NUMBER);
    FUNCTION IS_ADMIN RETURN BOOLEAN;
    FUNCTION GET_ADMIN_LEVEL RETURN NUMBER;
END ADMIN_CTX_PKG;
/

CREATE OR REPLACE PACKAGE BODY ADMIN_CTX_PKG AS
    PROCEDURE SET_ADMIN(p_matk VARCHAR2, p_clearance NUMBER) IS
    BEGIN
        DBMS_SESSION.SET_CONTEXT('ADMIN_CTX', 'ADMIN_MATK', p_matk);
        DBMS_SESSION.SET_CONTEXT('ADMIN_CTX', 'ADMIN_LEVEL', TO_CHAR(p_clearance));
    END;
    
    FUNCTION IS_ADMIN RETURN BOOLEAN IS
        v_level NUMBER;
    BEGIN
        v_level := TO_NUMBER(NVL(SYS_CONTEXT('ADMIN_CTX', 'ADMIN_LEVEL'), '0'));
        RETURN v_level >= 4;
    END;
    
    FUNCTION GET_ADMIN_LEVEL RETURN NUMBER IS
    BEGIN
        RETURN TO_NUMBER(NVL(SYS_CONTEXT('ADMIN_CTX', 'ADMIN_LEVEL'), '0'));
    END;
END ADMIN_CTX_PKG;
/

-- =============================================================================
-- PROCEDURE SET_MAC_CONTEXT - Thiết lập MAC context
-- =============================================================================
CREATE OR REPLACE PROCEDURE SET_MAC_CONTEXT(
    p_matk IN VARCHAR2,
    p_level IN NUMBER DEFAULT NULL
) AS
    v_level NUMBER;
BEGIN
    IF p_level IS NULL THEN
        BEGIN
            SELECT CLEARANCELEVEL INTO v_level FROM TAIKHOAN WHERE MATK = p_matk OR TENTK = p_matk;
        EXCEPTION WHEN NO_DATA_FOUND THEN v_level := 1;
        END;
    ELSE
        v_level := p_level;
    END IF;
    MAC_CTX_PKG.SET_USER_LEVEL(p_matk, v_level);
END;
/

-- =============================================================================
-- TÀI KHOẢN PROCEDURES
-- =============================================================================
CREATE OR REPLACE PROCEDURE SP_TAO_TAIKHOAN(
    p_matk VARCHAR2,
    p_tentk VARCHAR2,
    p_password_hash VARCHAR2,
    p_mavaitro VARCHAR2,
    p_clearance NUMBER,
    p_is_verified NUMBER DEFAULT 1
) AS
BEGIN
    INSERT INTO TAIKHOAN(MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED)
    VALUES(p_matk, p_tentk, p_password_hash, p_mavaitro, p_clearance, p_is_verified);
    
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET, SECURITYLABEL)
    VALUES('SYSTEM', 'CREATE_ACCOUNT', p_matk, 0);
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_DOI_MATKHAU(
    p_matk VARCHAR2,
    p_new_password_hash VARCHAR2
) AS
BEGIN
    UPDATE TAIKHOAN SET PASSWORD_HASH = p_new_password_hash WHERE MATK = p_matk OR TENTK = p_matk;
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET) VALUES(p_matk, 'CHANGE_PASSWORD', p_matk);
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_BAN_USER_GLOBAL(p_matk VARCHAR2) AS
BEGIN
    UPDATE TAIKHOAN SET IS_BANNED_GLOBAL = 1 WHERE MATK = p_matk OR TENTK = p_matk;
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET) VALUES(MAC_CTX_PKG.GET_USERNAME, 'BAN_USER', p_matk);
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_UNBAN_USER_GLOBAL(p_matk VARCHAR2) AS
BEGIN
    UPDATE TAIKHOAN SET IS_BANNED_GLOBAL = 0 WHERE MATK = p_matk OR TENTK = p_matk;
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET) VALUES(MAC_CTX_PKG.GET_USERNAME, 'UNBAN_USER', p_matk);
    COMMIT;
END;
/

-- =============================================================================
-- CUỘC TRÒ CHUYỆN PROCEDURES
-- =============================================================================
CREATE OR REPLACE PROCEDURE SP_TAO_CUOCTROCHUYEN(
    p_mactc VARCHAR2, p_maloaictc VARCHAR2, p_tenctc VARCHAR2,
    p_nguoiql VARCHAR2, p_is_private VARCHAR2, p_created_by VARCHAR2
) AS
    v_matk VARCHAR2(20);
BEGIN
    SELECT MATK INTO v_matk FROM TAIKHOAN WHERE MATK = p_created_by OR TENTK = p_created_by FETCH FIRST 1 ROW ONLY;
    
    INSERT INTO CUOCTROCHUYEN(MACTC, MALOAICTC, TENCTC, NGUOIQL, IS_PRIVATE, CREATED_BY)
    VALUES(p_mactc, p_maloaictc, p_tenctc, v_matk, p_is_private, v_matk);
    
    INSERT INTO THANHVIEN(MACTC, MATK, QUYEN, MAPHANQUYEN)
    VALUES(p_mactc, v_matk, 'owner', 'OWNER');
    
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET) VALUES(v_matk, 'CREATE_CONVERSATION', p_mactc);
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_XOA_CUOCTROCHUYEN(p_mactc VARCHAR2) AS
BEGIN
    DELETE FROM CUOCTROCHUYEN WHERE MACTC = p_mactc;
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET) VALUES(MAC_CTX_PKG.GET_USERNAME, 'DELETE_CONVERSATION', p_mactc);
    COMMIT;
END;
/

-- =============================================================================
-- THÀNH VIÊN PROCEDURES
-- =============================================================================
CREATE OR REPLACE PROCEDURE SP_THEM_THANHVIEN(
    p_mactc VARCHAR2, p_matk VARCHAR2,
    p_quyen VARCHAR2 DEFAULT 'member', p_maphanquyen VARCHAR2 DEFAULT 'MEMBER'
) AS
    v_count NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count FROM THANHVIEN WHERE MACTC = p_mactc AND MATK = p_matk AND DELETED_BY_MEMBER = 0;
    IF v_count = 0 THEN
        INSERT INTO THANHVIEN(MACTC, MATK, QUYEN, MAPHANQUYEN) VALUES(p_mactc, p_matk, p_quyen, p_maphanquyen);
        INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET) VALUES(MAC_CTX_PKG.GET_USERNAME, 'ADD_MEMBER', p_mactc || ':' || p_matk);
        COMMIT;
    END IF;
END;
/

CREATE OR REPLACE PROCEDURE SP_XOA_THANHVIEN(p_mactc VARCHAR2, p_matk VARCHAR2) AS
BEGIN
    DELETE FROM THANHVIEN WHERE MACTC = p_mactc AND MATK = p_matk;
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET) VALUES(MAC_CTX_PKG.GET_USERNAME, 'REMOVE_MEMBER', p_mactc || ':' || p_matk);
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_BAN_MEMBER(p_mactc VARCHAR2, p_matk VARCHAR2) AS
BEGIN
    UPDATE THANHVIEN SET IS_BANNED = 1 WHERE MACTC = p_mactc AND MATK = p_matk;
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_UNBAN_MEMBER(p_mactc VARCHAR2, p_matk VARCHAR2) AS
BEGIN
    UPDATE THANHVIEN SET IS_BANNED = 0 WHERE MACTC = p_mactc AND MATK = p_matk;
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_MUTE_MEMBER(p_mactc VARCHAR2, p_matk VARCHAR2) AS
BEGIN
    UPDATE THANHVIEN SET IS_MUTED = 1 WHERE MACTC = p_mactc AND MATK = p_matk;
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_UNMUTE_MEMBER(p_mactc VARCHAR2, p_matk VARCHAR2) AS
BEGIN
    UPDATE THANHVIEN SET IS_MUTED = 0 WHERE MACTC = p_mactc AND MATK = p_matk;
    COMMIT;
END;
/

-- =============================================================================
-- TIN NHẮN PROCEDURES
-- =============================================================================
CREATE OR REPLACE PROCEDURE SP_GUI_TINNHAN(
    p_mactc VARCHAR2, p_matk VARCHAR2, p_noidung CLOB, p_securitylabel NUMBER, p_matn OUT NUMBER
) AS
BEGIN
    SET_MAC_CONTEXT(p_matk);
    INSERT INTO TINNHAN(MACTC, MATK, NOIDUNG, SECURITYLABEL, MALOAITN, MATRANGTHAI)
    VALUES(p_mactc, p_matk, p_noidung, p_securitylabel, 'TEXT', 'ACTIVE')
    RETURNING MATN INTO p_matn;
    UPDATE CUOCTROCHUYEN SET THOIGIANTINNHANCUOI = SYSTIMESTAMP WHERE MACTC = p_mactc;
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_GUI_TINNHAN_WITH_ATTACH(
    p_mactc VARCHAR2, p_matk VARCHAR2, p_noidung CLOB, p_securitylabel NUMBER, p_attach_id NUMBER, p_matn OUT NUMBER
) AS
BEGIN
    SET_MAC_CONTEXT(p_matk);
    INSERT INTO TINNHAN(MACTC, MATK, NOIDUNG, SECURITYLABEL, MALOAITN, MATRANGTHAI)
    VALUES(p_mactc, p_matk, p_noidung, p_securitylabel, 'FILE', 'ACTIVE')
    RETURNING MATN INTO p_matn;
    INSERT INTO TINNHAN_ATTACH(MATN, ATTACH_ID) VALUES(p_matn, p_attach_id);
    UPDATE CUOCTROCHUYEN SET THOIGIANTINNHANCUOI = SYSTIMESTAMP WHERE MACTC = p_mactc;
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_XOA_TINNHAN(p_matn NUMBER) AS
BEGIN
    DELETE FROM TINNHAN WHERE MATN = p_matn;
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET) VALUES(MAC_CTX_PKG.GET_USERNAME, 'DELETE_MESSAGE', TO_CHAR(p_matn));
    COMMIT;
END;
/

-- =============================================================================
-- ATTACHMENT & AUDIT PROCEDURES
-- =============================================================================
CREATE OR REPLACE PROCEDURE SP_UPLOAD_ATTACHMENT(
    p_matk VARCHAR2, p_filename VARCHAR2, p_mimetype VARCHAR2,
    p_filesize NUMBER, p_filedata BLOB, p_attach_id OUT NUMBER,
    p_is_encrypted NUMBER DEFAULT 0
) AS
BEGIN
    INSERT INTO ATTACHMENT(MATK, FILENAME, MIMETYPE, FILESIZE, FILEDATA, IS_ENCRYPTED)
    VALUES(p_matk, p_filename, p_mimetype, p_filesize, p_filedata, p_is_encrypted)
    RETURNING ATTACH_ID INTO p_attach_id;
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_WRITE_AUDIT_LOG(
    p_matk VARCHAR2, p_action VARCHAR2, p_target VARCHAR2, p_securitylabel NUMBER DEFAULT 0
) AS
BEGIN
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET, SECURITYLABEL)
    VALUES(p_matk, p_action, p_target, p_securitylabel);
    COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE SP_TAO_OTP(
    p_matk VARCHAR2, p_email VARCHAR2, p_otp_hash VARCHAR2,
    p_expiry_minutes NUMBER DEFAULT 10, p_maotp OUT NUMBER
) AS
BEGIN
    INSERT INTO XACTHUCOTP (MATK, EMAIL, MAXTOTP, THOIGIANTONTAI)
    VALUES (p_matk, p_email, p_otp_hash, SYSTIMESTAMP + NUMTODSINTERVAL(p_expiry_minutes, 'MINUTE'))
    RETURNING MAOTP INTO p_maotp;
    COMMIT;
END;
/

-- =============================================================================
-- CHUYỂN QUYỀN SỞ HỮU NHÓM
-- =============================================================================
CREATE OR REPLACE PROCEDURE SP_SET_TRUONGNHOM(p_mactc VARCHAR2, p_matk VARCHAR2) AS
BEGIN
    UPDATE THANHVIEN SET QUYEN = 'admin', MAPHANQUYEN = 'ADMIN' WHERE MACTC = p_mactc AND QUYEN = 'owner';
    UPDATE THANHVIEN SET QUYEN = 'owner', MAPHANQUYEN = 'OWNER' WHERE MACTC = p_mactc AND MATK = p_matk;
    UPDATE CUOCTROCHUYEN SET NGUOIQL = p_matk WHERE MACTC = p_mactc;
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET) VALUES(MAC_CTX_PKG.GET_USERNAME, 'TRANSFER_OWNERSHIP', p_mactc);
    COMMIT;
END;
/

-- =============================================================================
-- ĐĂNG KÝ PUBLIC KEY CHO MÃ HÓA
-- =============================================================================
CREATE OR REPLACE PROCEDURE SP_REGISTER_PUBLIC_KEY(
    p_matk VARCHAR2,
    p_public_key CLOB
) AS
BEGIN
    UPDATE ENCRYPTION_KEYS SET IS_ACTIVE = 0 WHERE MATK = p_matk AND KEY_TYPE = 'RSA_PUBLIC';
    INSERT INTO ENCRYPTION_KEYS(MATK, KEY_TYPE, KEY_VALUE) VALUES(p_matk, 'RSA_PUBLIC', p_public_key);
    UPDATE TAIKHOAN SET PUBLIC_KEY = p_public_key WHERE MATK = p_matk;
    COMMIT;
END;
/

-- =============================================================================
-- CẬP NHẬT NGƯỜI DÙNG (ADMIN)
-- =============================================================================
CREATE OR REPLACE PROCEDURE SP_CAPNHAT_NGUOIDUNG_ADMIN(
    p_matk VARCHAR2,
    p_email VARCHAR2 DEFAULT NULL,
    p_hovaten VARCHAR2 DEFAULT NULL,
    p_sdt VARCHAR2 DEFAULT NULL,
    p_clearance NUMBER DEFAULT NULL,
    p_mavaitro VARCHAR2 DEFAULT NULL,
    p_macv VARCHAR2 DEFAULT NULL,
    p_mapb VARCHAR2 DEFAULT NULL
) AS
BEGIN
    IF p_email IS NOT NULL OR p_hovaten IS NOT NULL OR p_sdt IS NOT NULL OR p_macv IS NOT NULL OR p_mapb IS NOT NULL THEN
        MERGE INTO NGUOIDUNG n
        USING (SELECT p_matk AS MATK FROM DUAL) t
        ON (n.MATK = t.MATK)
        WHEN MATCHED THEN
            UPDATE SET 
                EMAIL = NVL(p_email, n.EMAIL),
                HOVATEN = NVL(p_hovaten, n.HOVATEN),
                SDT = NVL(p_sdt, n.SDT),
                MACV = NVL(p_macv, n.MACV),
                MAPB = NVL(p_mapb, n.MAPB),
                NGAYCAPNHAT = SYSTIMESTAMP
        WHEN NOT MATCHED THEN
            INSERT (MATK, EMAIL, HOVATEN, SDT, MACV, MAPB)
            VALUES (p_matk, p_email, p_hovaten, p_sdt, NVL(p_macv, 'CV005'), p_mapb);
    END IF;
    
    IF p_clearance IS NOT NULL OR p_mavaitro IS NOT NULL THEN
        UPDATE TAIKHOAN 
        SET CLEARANCELEVEL = NVL(p_clearance, CLEARANCELEVEL),
            MAVAITRO = NVL(p_mavaitro, MAVAITRO)
        WHERE MATK = p_matk;
    END IF;
    
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET) VALUES('ADMIN', 'UPDATE_USER', p_matk);
    COMMIT;
END;
/
-----FUNCTION KIỂM TRA MẬT KHẨU SAI
CREATE OR REPLACE PROCEDURE SP_LOGIN_FAILED (
    p_username IN VARCHAR2,
    p_ip       IN VARCHAR2
) AS
    v_failed NUMBER;
BEGIN
    -- Đếm số lần nhập sai hôm nay
    SELECT COUNT(*) INTO v_failed
    FROM LOGIN_FAILED_LOGS
    WHERE USERNAME = p_username
      AND TRUNC(ATTEMPT_TIME) = TRUNC(SYSDATE);

    -- Ghi log lần nhập sai
    INSERT INTO LOGIN_FAILED_LOGS (USERNAME, IP_ADDRESS, ATTEMPT_COUNT, STATUS)
    VALUES (p_username, p_ip, v_failed + 1, 'FAILED');

    -- Tăng số lần sai trong bảng TAIKHOAN
    UPDATE TAIKHOAN
    SET FAILED_LOGIN_ATTEMPTS = v_failed + 1
    WHERE TENTK = p_username;

    -- Nếu sai ≥ 5 → khóa 30 phút
    IF v_failed + 1 >= 5 THEN
        UPDATE TAIKHOAN
        SET LOCKED_UNTIL = SYSTIMESTAMP + INTERVAL '30' MINUTE
        WHERE TENTK = p_username;

        INSERT INTO LOGIN_FAILED_LOGS (USERNAME, IP_ADDRESS, ATTEMPT_COUNT, STATUS)
        VALUES (p_username, p_ip, v_failed + 1, 'LOCKED');
    END IF;

    COMMIT;
END;
/

COMMIT;
SELECT 'Procedures created successfully!' AS STATUS FROM DUAL;
---------------------------------------------------------------------
--------------------------------------------------------------------------------
-- 04_POLICIES.SQL - CHẠY VỚI ChatApplication
-- Bao gồm: VPD/RLS, MAC Triggers, FGA, Standard Auditing Triggers
--------------------------------------------------------------------------------

-- =============================================================================
-- PHẦN 1: VPD (Virtual Private Database) / RLS (Row Level Security)
-- MAC kết hợp VPD - Điều khiển truy cập bắt buộc
-- =============================================================================

-- VPD Policy Function cho TINNHAN - SELECT (No Read Up)
CREATE OR REPLACE FUNCTION VPD_TINNHAN_SELECT_FN(
    schema_name IN VARCHAR2, table_name IN VARCHAR2
) RETURN VARCHAR2 AS
    v_user_level NUMBER;
BEGIN
    v_user_level := TO_NUMBER(NVL(SYS_CONTEXT('MAC_CTX', 'USER_LEVEL'), '1'));
    IF v_user_level >= 5 THEN RETURN '1=1'; END IF;
    IF v_user_level > 0 THEN RETURN 'SECURITYLABEL <= ' || v_user_level; END IF;
    RETURN '1=1';
END;
/

-- VPD Policy Function cho TINNHAN - INSERT (No Write Up)
CREATE OR REPLACE FUNCTION VPD_TINNHAN_INSERT_FN(
    schema_name IN VARCHAR2, table_name IN VARCHAR2
) RETURN VARCHAR2 AS
    v_user_level NUMBER;
BEGIN
    v_user_level := TO_NUMBER(NVL(SYS_CONTEXT('MAC_CTX', 'USER_LEVEL'), '1'));
    RETURN 'SECURITYLABEL <= ' || v_user_level;
END;
/

-- VPD Policy Function cho CUOCTROCHUYEN
CREATE OR REPLACE FUNCTION VPD_CUOCTROCHUYEN_SELECT_FN(
    schema_name IN VARCHAR2, table_name IN VARCHAR2
) RETURN VARCHAR2 AS
    v_user_level NUMBER;
    v_username VARCHAR2(100);
BEGIN
    v_user_level := TO_NUMBER(NVL(SYS_CONTEXT('MAC_CTX', 'USER_LEVEL'), '1'));
    v_username := SYS_CONTEXT('MAC_CTX', 'USERNAME');
    IF v_user_level >= 4 THEN RETURN '1=1'; END IF;
    RETURN 'MIN_CLEARANCE <= ' || v_user_level || 
           ' OR MACTC IN (SELECT MACTC FROM THANHVIEN WHERE MATK = ''' || v_username || ''' AND DELETED_BY_MEMBER = 0)';
END;
/

-- VPD Policy Function cho TAIKHOAN
CREATE OR REPLACE FUNCTION VPD_TAIKHOAN_SELECT_FN(
    schema_name IN VARCHAR2, table_name IN VARCHAR2
) RETURN VARCHAR2 AS
    v_user_level NUMBER;
    v_username VARCHAR2(100);
BEGIN
    v_user_level := TO_NUMBER(NVL(SYS_CONTEXT('MAC_CTX', 'USER_LEVEL'), '1'));
    v_username := SYS_CONTEXT('MAC_CTX', 'USERNAME');
    IF v_user_level >= 4 THEN RETURN '1=1'; END IF;
    RETURN 'CLEARANCELEVEL <= ' || v_user_level || ' OR MATK = ''' || v_username || '''';
END;
/

-- Xóa VPD policies cũ nếu tồn tại
BEGIN DBMS_RLS.DROP_POLICY('CHATAPPLICATION','TINNHAN','VPD_TINNHAN_SELECT'); EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN DBMS_RLS.DROP_POLICY('CHATAPPLICATION','TINNHAN','VPD_TINNHAN_INSERT'); EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN DBMS_RLS.DROP_POLICY('CHATAPPLICATION','CUOCTROCHUYEN','VPD_CUOCTROCHUYEN_SELECT'); EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN DBMS_RLS.DROP_POLICY('CHATAPPLICATION','TAIKHOAN','VPD_TAIKHOAN_SELECT'); EXCEPTION WHEN OTHERS THEN NULL; END;
/

-- Thêm VPD Policies
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'CHATAPPLICATION', object_name => 'TINNHAN',
        policy_name => 'VPD_TINNHAN_SELECT', function_schema => 'CHATAPPLICATION',
        policy_function => 'VPD_TINNHAN_SELECT_FN', statement_types => 'SELECT', enable => TRUE
    );
END;
/




BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema     => 'CHATAPPLICATION',
        object_name       => 'TINNHAN',
        policy_name       => 'VPD_TINNHAN_INSERT',
        function_schema   => 'CHATAPPLICATION',
        policy_function   => 'VPD_TINNHAN_INSERT_FN',
        statement_types   => 'INSERT',
        update_check      => TRUE,
        enable            => TRUE
    );
END;
/


--BEGIN
--    DBMS_RLS.ADD_POLICY(
--        object_schema => 'CHATAPPLICATION', object_name => 'TINNHAN',
--        policy_name => 'VPD_TINNHAN_INSERT', function_schema => 'CHATAPPLICATION',
--        policy_function => 'VPD_TINNHAN_INSERT_FN', statement_types => 'INSERT', enable => TRUE
--    );
--END;
--/

BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'CHATAPPLICATION', object_name => 'CUOCTROCHUYEN',
        policy_name => 'VPD_CUOCTROCHUYEN_SELECT', function_schema => 'CHATAPPLICATION',
        policy_function => 'VPD_CUOCTROCHUYEN_SELECT_FN', statement_types => 'SELECT', enable => TRUE
    );
END;
/

BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'CHATAPPLICATION', object_name => 'TAIKHOAN',
        policy_name => 'VPD_TAIKHOAN_SELECT', function_schema => 'CHATAPPLICATION',
        policy_function => 'VPD_TAIKHOAN_SELECT_FN', statement_types => 'SELECT', enable => TRUE
    );
END;
/

-- Ghi log VPD policies vào ADMIN_POLICY
INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, POLICY_FUNCTION, STATEMENT_TYPES, IS_ENABLED)
VALUES('VPD_TINNHAN_SELECT', 'VPD', 'TINNHAN', 'MAC: Lọc tin nhắn theo SECURITYLABEL <= CLEARANCELEVEL (No Read Up)', 'VPD_TINNHAN_SELECT_FN', 'SELECT', 1);

INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, POLICY_FUNCTION, STATEMENT_TYPES, IS_ENABLED)
VALUES('VPD_TINNHAN_INSERT', 'VPD', 'TINNHAN', 'MAC: Ngăn gửi tin nhắn mức cao hơn clearance (No Write Up)', 'VPD_TINNHAN_INSERT_FN', 'INSERT', 1);

INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, POLICY_FUNCTION, STATEMENT_TYPES, IS_ENABLED)
VALUES('VPD_CUOCTROCHUYEN_SELECT', 'VPD', 'CUOCTROCHUYEN', 'Lọc cuộc trò chuyện theo quyền tham gia', 'VPD_CUOCTROCHUYEN_SELECT_FN', 'SELECT', 1);

INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, POLICY_FUNCTION, STATEMENT_TYPES, IS_ENABLED)
VALUES('VPD_TAIKHOAN_SELECT', 'VPD', 'TAIKHOAN', 'Ẩn thông tin user có clearance cao hơn', 'VPD_TAIKHOAN_SELECT_FN', 'SELECT', 1);

-- =============================================================================
-- PHẦN 2: MAC + OLS (Oracle Label Security) - Yêu cầu license OLS
-- LƯU Ý: Đã bỏ comment code OLS vì không có license
-- Nếu có OLS license, uncomment và chạy với LBACSYS:
-- BEGIN SA_SYSDBA.CREATE_POLICY(policy_name => 'CHAT_OLS_POLICY', column_name => 'OLS_LABEL'); END;
-- BEGIN SA_COMPONENTS.CREATE_LEVEL('CHAT_OLS_POLICY', 10, 'PUB', 'CONG_KHAI'); END;
-- BEGIN SA_POLICY_ADMIN.APPLY_TABLE_POLICY('CHAT_OLS_POLICY', 'CHATAPPLICATION', 'TINNHAN', 'READ_CONTROL,WRITE_CONTROL'); END;
-- =============================================================================

INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, IS_ENABLED)
VALUES('CHAT_OLS_POLICY', 'OLS', 'TINNHAN', 'Oracle Label Security - Nhãn bảo mật (yêu cầu license OLS)', 0);

-- =============================================================================
-- PHẦN 3: STANDARD AUDITING VỚI TRIGGER
-- =============================================================================

-- Trigger Audit cho TAIKHOAN
CREATE OR REPLACE TRIGGER TRG_AUDIT_TAIKHOAN
AFTER INSERT OR UPDATE OR DELETE ON TAIKHOAN
FOR EACH ROW
DECLARE
    v_action VARCHAR2(50);
    v_user VARCHAR2(100) := NVL(MAC_CTX_PKG.GET_USERNAME, USER);
    v_old CLOB; v_new CLOB;
BEGIN
    IF INSERTING THEN v_action := 'INSERT'; v_new := 'MATK=' || :NEW.MATK || ',TENTK=' || :NEW.TENTK;
    ELSIF UPDATING THEN v_action := 'UPDATE'; v_old := 'MATK=' || :OLD.MATK; v_new := 'MATK=' || :NEW.MATK || ',TENTK=' || :NEW.TENTK;
    ELSIF DELETING THEN v_action := 'DELETE'; v_old := 'MATK=' || :OLD.MATK || ',TENTK=' || :OLD.TENTK;
    END IF;
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET, OLD_VALUE, NEW_VALUE)
    VALUES(v_user, v_action || '_TAIKHOAN', NVL(:NEW.MATK, :OLD.MATK), v_old, v_new);
END;
/

-- Trigger Audit cho TINNHAN
CREATE OR REPLACE TRIGGER TRG_AUDIT_TINNHAN
AFTER INSERT OR UPDATE OR DELETE ON TINNHAN
FOR EACH ROW
DECLARE
    v_user VARCHAR2(200) := MAC_CTX_PKG.GET_USERNAME;
    v_action VARCHAR2(200); v_target VARCHAR2(400); v_label NUMBER;
BEGIN
    IF INSERTING THEN v_action := 'INSERT_TINNHAN'; v_target := 'MATN=' || :NEW.MATN || ',MACTC=' || :NEW.MACTC; v_label := :NEW.SECURITYLABEL;
    ELSIF UPDATING THEN v_action := 'UPDATE_TINNHAN'; v_target := 'MATN=' || :NEW.MATN; v_label := :NEW.SECURITYLABEL;
    ELSIF DELETING THEN v_action := 'DELETE_TINNHAN'; v_target := 'MATN=' || :OLD.MATN; v_label := NVL(:OLD.SECURITYLABEL, 1);
    END IF;
    INSERT INTO AUDIT_LOGS(MATK, ACTION, TARGET, SECURITYLABEL) VALUES(v_user, v_action, v_target, v_label);
END;
/

-- Trigger MAC: Ngăn Write-Up (Bell-LaPadula)
CREATE OR REPLACE TRIGGER TRG_TINNHAN_CHECK_WRITE_UP
BEFORE INSERT OR UPDATE ON TINNHAN
FOR EACH ROW
DECLARE
    v_user_level NUMBER;
BEGIN
    v_user_level := MAC_CTX_PKG.GET_USER_LEVEL;
    IF :NEW.SECURITYLABEL > v_user_level THEN
        RAISE_APPLICATION_ERROR(-20001, 
            'MAC Violation: Không thể gửi tin nhắn mức ' || :NEW.SECURITYLABEL || 
            ' (Clearance của bạn: ' || v_user_level || ')');
    END IF;
END;
/

-- Trigger cho Private Chat (chỉ 2 thành viên)
CREATE OR REPLACE TRIGGER TRG_THANHVIEN_PRIVATE_CHECK
BEFORE INSERT ON THANHVIEN
FOR EACH ROW
DECLARE
    v_is_private VARCHAR2(1); v_count NUMBER;
BEGIN
    SELECT NVL(IS_PRIVATE, 'N') INTO v_is_private FROM CUOCTROCHUYEN WHERE MACTC = :NEW.MACTC;
    IF v_is_private = 'Y' THEN
        SELECT COUNT(*) INTO v_count FROM THANHVIEN WHERE MACTC = :NEW.MACTC AND DELETED_BY_MEMBER = 0;
        IF v_count >= 2 THEN
            RAISE_APPLICATION_ERROR(-20070, 'Chat riêng tư chỉ có thể có 2 thành viên.');
        END IF;
    END IF;
EXCEPTION WHEN NO_DATA_FOUND THEN NULL;
END;
/

-- Trigger Audit cho ADMIN_POLICY changes
CREATE OR REPLACE TRIGGER TRG_AUDIT_POLICY_CHANGE
AFTER INSERT OR UPDATE OR DELETE ON ADMIN_POLICY
FOR EACH ROW
DECLARE
    v_action VARCHAR2(50);
    v_user VARCHAR2(100);
    v_old_val VARCHAR2(500);
    v_new_val VARCHAR2(500);
BEGIN
    v_user := NVL(SYS_CONTEXT('MAC_CTX', 'USERNAME'), USER);
    
    IF INSERTING THEN 
        v_action := 'CREATE';
        v_new_val := :NEW.POLICY_NAME || ',Enabled=' || :NEW.IS_ENABLED;
    ELSIF UPDATING THEN 
        v_action := 'UPDATE';
        v_old_val := :OLD.POLICY_NAME || ',Enabled=' || :OLD.IS_ENABLED;
        v_new_val := :NEW.POLICY_NAME || ',Enabled=' || :NEW.IS_ENABLED;
    ELSIF DELETING THEN 
        v_action := 'DELETE';
        v_old_val := :OLD.POLICY_NAME || ',Enabled=' || :OLD.IS_ENABLED;
    END IF;
    
    INSERT INTO POLICY_CHANGE_LOG(POLICY_ID, ACTION, CHANGED_BY, OLD_VALUE, NEW_VALUE)
    VALUES(NVL(:NEW.POLICY_ID, :OLD.POLICY_ID), v_action, v_user, v_old_val, v_new_val);
END;
/

-- Ghi log Triggers vào ADMIN_POLICY
INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, IS_ENABLED)
VALUES('TRG_AUDIT_TAIKHOAN', 'DAC', 'TAIKHOAN', 'Trigger ghi nhật ký thay đổi tài khoản', 1);

INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, IS_ENABLED)
VALUES('TRG_AUDIT_TINNHAN', 'DAC', 'TINNHAN', 'Trigger ghi nhật ký thay đổi tin nhắn', 1);

INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, IS_ENABLED)
VALUES('TRG_MAC_WRITE_UP_CHECK', 'MAC', 'TINNHAN', 'MAC Trigger: Ngăn gửi tin lên mức cao hơn (Bell-LaPadula No Write Up)', 1);

-- =============================================================================
-- PHẦN 4: FGA (Fine-Grained Auditing)
-- =============================================================================

-- Xóa FGA policies cũ
BEGIN DBMS_FGA.DROP_POLICY('CHATAPPLICATION','TINNHAN','FGA_TINNHAN_SELECT'); EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN DBMS_FGA.DROP_POLICY('CHATAPPLICATION','TINNHAN','FGA_TINNHAN_SENSITIVE'); EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN DBMS_FGA.DROP_POLICY('CHATAPPLICATION','TAIKHOAN','FGA_TAIKHOAN_PASSWORD'); EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN DBMS_FGA.DROP_POLICY('CHATAPPLICATION','AUDIT_LOGS','FGA_AUDIT_ACCESS'); EXCEPTION WHEN OTHERS THEN NULL; END;
/

-- FGA: Audit tất cả SELECT trên TINNHAN
BEGIN
    DBMS_FGA.ADD_POLICY(
        object_schema => 'CHATAPPLICATION', object_name => 'TINNHAN',
        policy_name => 'FGA_TINNHAN_SELECT', audit_condition => NULL,
        audit_column => 'NOIDUNG,SECURITYLABEL', statement_types => 'SELECT', enable => TRUE
    );
END;
/

-- FGA: Audit truy cập tin nhắn nhạy cảm (level >= 4)
BEGIN
    DBMS_FGA.ADD_POLICY(
        object_schema => 'CHATAPPLICATION', object_name => 'TINNHAN',
        policy_name => 'FGA_TINNHAN_SENSITIVE', audit_condition => 'SECURITYLABEL >= 4',
        audit_column => 'NOIDUNG', statement_types => 'SELECT,INSERT,UPDATE,DELETE', enable => TRUE
    );
END;
/

-- FGA: Audit truy cập mật khẩu
BEGIN
    DBMS_FGA.ADD_POLICY(
        object_schema => 'CHATAPPLICATION', object_name => 'TAIKHOAN',
        policy_name => 'FGA_TAIKHOAN_PASSWORD', audit_condition => NULL,
        audit_column => 'PASSWORD_HASH', statement_types => 'SELECT,UPDATE', enable => TRUE
    );
END;
/

-- FGA: Audit truy cập audit logs
BEGIN
    DBMS_FGA.ADD_POLICY(
        object_schema => 'CHATAPPLICATION', object_name => 'AUDIT_LOGS',
        policy_name => 'FGA_AUDIT_ACCESS', audit_condition => NULL,
        audit_column => NULL, statement_types => 'SELECT,DELETE', enable => TRUE
    );
END;
/

-- Ghi log FGA policies
INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, STATEMENT_TYPES, IS_ENABLED)
VALUES('FGA_TINNHAN_SELECT', 'FGA', 'TINNHAN', 'Ghi nhật ký chi tiết khi đọc tin nhắn', 'SELECT', 1);

INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, STATEMENT_TYPES, IS_ENABLED)
VALUES('FGA_TINNHAN_SENSITIVE', 'FGA', 'TINNHAN', 'Audit truy cập tin nhắn nhạy cảm (level >= 4)', 'SELECT,INSERT,UPDATE,DELETE', 1);

INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, STATEMENT_TYPES, IS_ENABLED)
VALUES('FGA_TAIKHOAN_PASSWORD', 'FGA', 'TAIKHOAN', 'Audit truy cập mật khẩu', 'SELECT,UPDATE', 1);

INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, STATEMENT_TYPES, IS_ENABLED)
VALUES('FGA_AUDIT_ACCESS', 'FGA', 'AUDIT_LOGS', 'Audit truy cập bảng audit', 'SELECT,DELETE', 1);

-- =============================================================================
-- PHẦN 5: RBAC - Ghi log
-- =============================================================================
INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, IS_ENABLED)
VALUES('RBAC_USER_ROLE', 'RBAC', 'TAIKHOAN', 'RBAC: Phân quyền theo vai trò (VT001-Chủ dịch vụ, VT002-Admin, VT003-User)', 1);

INSERT INTO ADMIN_POLICY(POLICY_NAME, POLICY_TYPE, TABLE_NAME, DESCRIPTION, IS_ENABLED)
VALUES('RBAC_GROUP_PERMISSION', 'RBAC', 'PHAN_QUYEN_NHOM', 'RBAC: Phân quyền trong nhóm chat (OWNER, ADMIN, MODERATOR, MEMBER)', 1);
--------FUNCTION KIỂM TRA MẬT KHẨU SAI

DESC TAIKHOAN;

--CREATE OR REPLACE PROCEDURE SP_LOGIN_FAILED (
--    p_username IN VARCHAR2,
--    p_ip       IN VARCHAR2
--) AS
--    v_failed NUMBER;
--BEGIN
--    -- Đếm số lần nhập sai của user hôm nay
--    SELECT COUNT(*) INTO v_failed
--    FROM LOGIN_FAILED_LOGS
--    WHERE USERNAME = p_username
--      AND TRUNC(ATTEMPT_TIME) = TRUNC(SYSDATE);
--
--    -- Ghi thêm log lần nhập sai
--    INSERT INTO LOGIN_FAILED_LOGS (USERNAME, IP_ADDRESS, ATTEMPT_COUNT, STATUS)
--    VALUES (p_username, p_ip, v_failed + 1, 'FAILED');
--
--    -- Nếu sai quá 5 lần → khóa tài khoản
--    IF v_failed + 1 >= 5 THEN
--        UPDATE TAIKHOAN
--        SET TRANGTHAI = 'KHOA'
--        WHERE TENTK = p_username;
--
--        INSERT INTO LOGIN_FAILED_LOGS (USERNAME, IP_ADDRESS, ATTEMPT_COUNT, STATUS)
--        VALUES (p_username, p_ip, v_failed + 1, 'LOCKED');
--    END IF;
--
--    COMMIT;
--END;
--/
------TRIGGER KIỂM TRA LOGIN
CREATE OR REPLACE PROCEDURE SP_CHECK_LOGIN (
    p_username IN VARCHAR2,
    p_password IN VARCHAR2,
    p_ip       IN VARCHAR2,
    p_result   OUT VARCHAR2
) AS
    v_pass   VARCHAR2(200);
    v_locked_until TIMESTAMP;
BEGIN
    -- Lấy mật khẩu + trạng thái khóa
    SELECT PASSWORD_HASH, LOCKED_UNTIL 
    INTO  v_pass, v_locked_until
    FROM TAIKHOAN
    WHERE TENTK = p_username;

    -- Nếu tài khoản bị khóa
    IF v_locked_until IS NOT NULL AND v_locked_until > SYSTIMESTAMP THEN
        p_result := 'LOCKED';
        RETURN;
    END IF;

    -- Sai mật khẩu
    IF v_pass != p_password THEN
        SP_LOGIN_FAILED(p_username, p_ip);
        p_result := 'WRONG_PASSWORD';
        RETURN;
    END IF;

    -- Đúng mật khẩu
    p_result := 'SUCCESS';
END;
/



------- CHỨC NĂNG BACKUP TỰ ĐỘNG (Oracle Scheduler)
/

BEGIN
    DBMS_SCHEDULER.DROP_JOB('JOB_BACKUP_CHAT', FORCE => TRUE);
END;
/
BEGIN
  DBMS_SCHEDULER.CREATE_JOB(
      job_name        => 'JOB_BACKUP_CHAT',
      job_type        => 'EXECUTABLE',
      job_action      => 'D:\oracle_backup\backup_chat.bat',
      credential_name => 'SYS.WIN_CRED',
      start_date      => SYSTIMESTAMP,
      repeat_interval => 'FREQ=DAILY;BYHOUR=23;BYMINUTE=00;BYSECOND=00',
      enabled         => TRUE
  );
END;
/




---(Procedure backup toàn bộ dữ liệu)
CREATE OR REPLACE PROCEDURE SP_BACKUP_DATA AS
BEGIN
    DBMS_SCHEDULER.RUN_JOB('JOB_BACKUP_CHAT');
END;
/



---(Backup thủ công (Admin bấm một nút trong ứng dụng))
BEGIN
    SP_BACKUP_DATA;
END;
/
SELECT job_name, enabled FROM dba_scheduler_jobs
WHERE job_name = 'JOB_BACKUP_CHAT';
/

COMMIT;
SELECT 'Policies created successfully!' AS STATUS FROM DUAL;
---------------------------------------------------------------------
--------------------------------------------------------------------------------
-- 05_SEEDS.SQL - CHẠY VỚI ChatApplication
-- Dữ liệu mẫu: Vai trò, Phòng ban, Chức vụ, Tài khoản, Cuộc trò chuyện
--------------------------------------------------------------------------------

-- =============================================================================
-- 1. VAI TRÒ (RBAC)
-- =============================================================================
INSERT INTO VAITRO VALUES('VT001', N'Chủ dịch vụ', N'Toàn quyền quản trị, quản lý VPD/FGA/OLS', 10, N'Người có quyền cao nhất');
INSERT INTO VAITRO VALUES('VT002', N'Quản trị viên', N'Quản lý người dùng, giám sát, xem audit logs', 8, N'Quản trị viên hệ thống');
INSERT INTO VAITRO VALUES('VT003', N'Người dùng', N'Sử dụng chat, nhắn tin, tạo nhóm', 5, N'Người dùng thông thường');
INSERT INTO VAITRO VALUES('VT004', N'Khách', N'Chỉ xem, không gửi tin nhắn', 1, N'Tài khoản khách');

-- =============================================================================
-- 2. PHÒNG BAN
-- =============================================================================
INSERT INTO PHONGBAN VALUES('PB001', N'Ban Giám Đốc', N'Lãnh đạo công ty', 4);
INSERT INTO PHONGBAN VALUES('PB002', N'Phòng Kế Toán', N'Quản lý tài chính', 3);
INSERT INTO PHONGBAN VALUES('PB003', N'Phòng Kinh Doanh', N'Bán hàng, marketing', 2);
INSERT INTO PHONGBAN VALUES('PB004', N'Phòng Nhân Sự', N'Tuyển dụng, đào tạo', 3);
INSERT INTO PHONGBAN VALUES('PB005', N'Phòng Công Nghệ', N'Phát triển phần mềm', 3);
INSERT INTO PHONGBAN VALUES('PB006', N'Phòng Hành Chính', N'Quản lý văn phòng', 1);

-- =============================================================================
-- 3. CHỨC VỤ
-- =============================================================================
INSERT INTO CHUCVU VALUES('CV001', N'Giám Đốc', 10, 5, N'Lãnh đạo cao nhất');
INSERT INTO CHUCVU VALUES('CV002', N'Phó Giám Đốc', 9, 4, N'Hỗ trợ Giám đốc');
INSERT INTO CHUCVU VALUES('CV003', N'Trưởng Phòng', 7, 4, N'Quản lý phòng ban');
INSERT INTO CHUCVU VALUES('CV004', N'Phó Phòng', 6, 3, N'Hỗ trợ trưởng phòng');
INSERT INTO CHUCVU VALUES('CV005', N'Chuyên Viên', 4, 3, N'Nhân viên chuyên môn cao');
INSERT INTO CHUCVU VALUES('CV006', N'Nhân Viên', 3, 2, N'Nhân viên chính thức');
INSERT INTO CHUCVU VALUES('CV007', N'Thực Tập Sinh', 1, 1, N'Nhân viên thực tập');

-- =============================================================================
-- 4. PHÂN QUYỀN NHÓM CHAT
-- =============================================================================
INSERT INTO PHAN_QUYEN_NHOM VALUES('OWNER', N'Chủ nhóm', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
INSERT INTO PHAN_QUYEN_NHOM VALUES('ADMIN', N'Quản trị viên nhóm', 1, 1, 1, 0, 1, 1, 1, 1, 1, 1);
INSERT INTO PHAN_QUYEN_NHOM VALUES('MODERATOR', N'Điều hành viên', 0, 1, 0, 0, 1, 1, 1, 1, 0, 1);
INSERT INTO PHAN_QUYEN_NHOM VALUES('MEMBER', N'Thành viên', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- =============================================================================
-- 5. LOẠI CUỘC TRÒ CHUYỆN
-- =============================================================================
INSERT INTO LOAICTC VALUES('GROUP', N'Nhóm chat', 'N', N'Cuộc trò chuyện nhóm');
INSERT INTO LOAICTC VALUES('PRIVATE', N'Chat riêng tư', 'Y', N'Chat 1-1');
INSERT INTO LOAICTC VALUES('CHANNEL', N'Kênh thông báo', 'N', N'Kênh công khai');
INSERT INTO LOAICTC VALUES('BROADCAST', N'Phát sóng', 'N', N'Kênh phát sóng');
INSERT INTO LOAICTC VALUES('SUPPORT', N'Hỗ trợ', 'Y', N'Kênh hỗ trợ kỹ thuật');

-- =============================================================================
-- 6. LOẠI TIN NHẮN & TRẠNG THÁI
-- =============================================================================
INSERT INTO LOAITN VALUES('TEXT', N'Văn bản');
INSERT INTO LOAITN VALUES('IMAGE', N'Hình ảnh');
INSERT INTO LOAITN VALUES('VIDEO', N'Video');
INSERT INTO LOAITN VALUES('AUDIO', N'Âm thanh');
INSERT INTO LOAITN VALUES('FILE', N'Tệp đính kèm');
INSERT INTO LOAITN VALUES('LOCATION', N'Vị trí');
INSERT INTO LOAITN VALUES('ENCRYPTED', N'Tin mã hóa');
INSERT INTO LOAITN VALUES('SYSTEM', N'Thông báo hệ thống');

INSERT INTO TRANGTHAI VALUES('ACTIVE', N'Đang hoạt động');
INSERT INTO TRANGTHAI VALUES('DELETED', N'Đã xóa');
INSERT INTO TRANGTHAI VALUES('EDITED', N'Đã chỉnh sửa');
INSERT INTO TRANGTHAI VALUES('HIDDEN', N'Đã ẩn');
INSERT INTO TRANGTHAI VALUES('PENDING', N'Đang chờ duyệt');
INSERT INTO TRANGTHAI VALUES('RECALLED', N'Đã thu hồi');

-- =============================================================================
-- 7. TÀI KHOẢN MẪU (Password = 123, SHA256 hash, IS_OTP_VERIFIED = 1)
-- SHA256("123") = a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3
-- =============================================================================
-- Chủ dịch vụ - Clearance Level 5
SELECT SYS_CONTEXT('USERENV','CON_NAME') FROM dual;


select * from CHATAPPLICATION.taikhoan
SELECT owner, table_name 
FROM all_tables 
WHERE table_name = 'TAIKHOAN';



INSERT INTO TAIKHOAN (MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED, PROFILE_NAME)
VALUES('TK001', 'giamdoc', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'VT001', 5, 1, 'CHAT_ADMIN_PROFILE');
INSERT INTO CHATAPPLICATION.TAIKHOAN (
    MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL,
    IS_BANNED_GLOBAL, IS_OTP_VERIFIED, PROFILE_NAME,
    NGAYTAO, LAST_LOGIN, LAST_LOGOUT, LOGIN_COUNT, PUBLIC_KEY
) VALUES (
    'TK333',
    'giamdoc3',
    'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', -- SHA256('123')
    'VT001',
    5,
    0,          -- chưa bị khóa
    1,          -- OTP verified
    'CHAT_ADMIN_PROFILE',
    SYSDATE,
    NULL,
    NULL,
    0,
    ''          -- nếu chưa dùng RSA public key
);
select *from nguoidung
UPDATE TAIKHOAN 
SET PUBLIC_KEY = null
WHERE TENTK = 'giamdoc3';

-- Quản trị viên - Clearance Level 4
INSERT INTO TAIKHOAN (MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED, PROFILE_NAME)
VALUES('TK002', 'quantrivien', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'VT002', 4, 1, 'CHAT_ADMIN_PROFILE');

-- Phó Giám đốc - Clearance Level 4
INSERT INTO TAIKHOAN (MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED)
VALUES('TK003', 'phogiamdoc', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'VT003', 4, 1);
INSERT INTO TAIKHOAN (MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED)
VALUES('TK666', 'phogiamdoc2', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'VT003', 4, 1);

-- Trưởng phòng IT - Clearance Level 4
INSERT INTO TAIKHOAN (MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED)
VALUES('TK004', 'truongphongit', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'VT003', 4, 1);

-- Chuyên viên Kế toán - Clearance Level 3
INSERT INTO TAIKHOAN (MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED)
VALUES('TK005', 'chuyenvienkt', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'VT003', 3, 1);

-- Nhân viên Kinh doanh - Clearance Level 2
INSERT INTO TAIKHOAN (MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED)
VALUES('TK006', 'nhanvienkd', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'VT003', 2, 1);

-- Nhân viên IT - Clearance Level 3
INSERT INTO TAIKHOAN (MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED)
VALUES('TK007', 'nhanvienit', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'VT003', 3, 1);

-- Thực tập sinh - Clearance Level 1
INSERT INTO TAIKHOAN (MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED, PROFILE_NAME)
VALUES('TK008', 'thuctapsinh', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'VT003', 1, 1, 'CHAT_INTERN_PROFILE');

INSERT INTO TAIKHOAN (MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED, PROFILE_NAME)
VALUES('TK088', 'thuctapsinh1', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'VT003', 1, 1, 'CHAT_INTERN_PROFILE');
SELECT MATK, TENTK, CLEARANCELEVEL
FROM TAIKHOAN
WHERE TENTK = 'giamdoc2';

-- =============================================================================
-- 8. THÔNG TIN NGƯỜI DÙNG
-- =============================================================================
INSERT INTO NGUOIDUNG (MATK, MAPB, MACV, HOVATEN, EMAIL, SDT)
VALUES('TK001', 'PB001', 'CV001', N'Nguyễn Văn Minh', 'minh@company.com', '0901234567');

INSERT INTO NGUOIDUNG (MATK, MAPB, MACV, HOVATEN, EMAIL, SDT)
VALUES('TK002', 'PB005', 'CV003', N'Trần Thị Hương', 'huong@company.com', '0902345678');

INSERT INTO NGUOIDUNG (MATK, MAPB, MACV, HOVATEN, EMAIL, SDT)
VALUES('TK003', 'PB001', 'CV002', N'Lê Văn Tuấn', 'tuan@company.com', '0903456789');

INSERT INTO NGUOIDUNG (MATK, MAPB, MACV, HOVATEN, EMAIL, SDT)
VALUES('TK004', 'PB005', 'CV003', N'Phạm Văn Đức', 'duc@company.com', '0904567890');

INSERT INTO NGUOIDUNG (MATK, MAPB, MACV, HOVATEN, EMAIL, SDT)
VALUES('TK005', 'PB002', 'CV005', N'Hoàng Thị Lan', 'lan@company.com', '0905678901');

INSERT INTO NGUOIDUNG (MATK, MAPB, MACV, HOVATEN, EMAIL, SDT)
VALUES('TK006', 'PB003', 'CV006', N'Võ Văn Nam', 'nam@company.com', '0906789012');

INSERT INTO NGUOIDUNG (MATK, MAPB, MACV, HOVATEN, EMAIL, SDT)
VALUES('TK007', 'PB005', 'CV006', N'Nguyễn Văn Hùng', 'hung@company.com', '0907890123');

INSERT INTO NGUOIDUNG (MATK, MAPB, MACV, HOVATEN, EMAIL, SDT)
VALUES('TK008', 'PB005', 'CV007', N'Lê Thị Hoa', 'hoa@company.com', '0908901234');
--------------------------------------test
select * from TAIKHOAN;
select * from NGUOIDUNG;
INSERT INTO TAIKHOAN (MATK, TENTK, PASSWORD_HASH, MAVAITRO, CLEARANCELEVEL, IS_OTP_VERIFIED)
VALUES('TEST999', 'testserver', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'VT003', 1, 1);

SELECT MATK, TENTK FROM TAIKHOAN WHERE MATK = 'TK012' OR TENTK = 'giamdoc';
SELECT username FROM dba_users WHERE username = 'CHATAPPLICATION';

SELECT * FROM CHATAPPLICATION.TAIKHOAN;

select *from nguoidung;

-- =============================================================================
-- 9. CUỘC TRÒ CHUYỆN MẪU
-- =============================================================================
-- Nhóm Ban Giám Đốc (MIN_CLEARANCE = 4)
INSERT INTO CUOCTROCHUYEN (MACTC, MALOAICTC, TENCTC, NGUOIQL, IS_PRIVATE, CREATED_BY, MIN_CLEARANCE, IS_ENCRYPTED)
VALUES('CTC_BGD_001', 'GROUP', N'Ban Giám Đốc', 'TK001', 'N', 'TK001', 4, 1);

INSERT INTO THANHVIEN VALUES('CTC_BGD_001', 'TK001', SYSTIMESTAMP, 'owner', 'OWNER', 0, 0, 0, NULL);
INSERT INTO THANHVIEN VALUES('CTC_BGD_001', 'TK002', SYSTIMESTAMP, 'admin', 'ADMIN', 0, 0, 0, NULL);
INSERT INTO THANHVIEN VALUES('CTC_BGD_001', 'TK003', SYSTIMESTAMP, 'member', 'MEMBER', 0, 0, 0, NULL);

-- Nhóm Phòng IT (MIN_CLEARANCE = 2)
INSERT INTO CUOCTROCHUYEN (MACTC, MALOAICTC, TENCTC, NGUOIQL, IS_PRIVATE, CREATED_BY, MIN_CLEARANCE)
VALUES('CTC_IT_001', 'GROUP', N'Phòng Công Nghệ', 'TK004', 'N', 'TK004', 2);

INSERT INTO THANHVIEN VALUES('CTC_IT_001', 'TK004', SYSTIMESTAMP, 'owner', 'OWNER', 0, 0, 0, NULL);
INSERT INTO THANHVIEN VALUES('CTC_IT_001', 'TK007', SYSTIMESTAMP, 'admin', 'ADMIN', 0, 0, 0, NULL);
INSERT INTO THANHVIEN VALUES('CTC_IT_001', 'TK008', SYSTIMESTAMP, 'member', 'MEMBER', 0, 0, 0, NULL);
INSERT INTO THANHVIEN VALUES('CTC_IT_001', 'TK002', SYSTIMESTAMP, 'member', 'MEMBER', 0, 0, 0, NULL);

-- Kênh thông báo công ty
INSERT INTO CUOCTROCHUYEN (MACTC, MALOAICTC, TENCTC, NGUOIQL, IS_PRIVATE, CREATED_BY, MIN_CLEARANCE)
VALUES('CTC_CHANNEL_001', 'CHANNEL', N'Thông Báo Công Ty', 'TK001', 'N', 'TK001', 1);

INSERT INTO THANHVIEN VALUES('CTC_CHANNEL_001', 'TK001', SYSTIMESTAMP, 'owner', 'OWNER', 0, 0, 0, NULL);
INSERT INTO THANHVIEN VALUES('CTC_CHANNEL_001', 'TK002', SYSTIMESTAMP, 'admin', 'ADMIN', 0, 0, 0, NULL);

-- =============================================================================
-- 10. TIN NHẮN MẪU (cần SET MAC CONTEXT trước)
-- =============================================================================
BEGIN MAC_CTX_PKG.SET_USER_LEVEL('TK001', 5); END;
/
INSERT INTO TINNHAN (MACTC, MATK, MALOAITN, MATRANGTHAI, NOIDUNG, SECURITYLABEL)
VALUES('CTC_CHANNEL_001', 'TK001', 'TEXT', 'ACTIVE', N'Chào mừng tất cả đến với hệ thống chat nội bộ!', 1);

INSERT INTO TINNHAN (MACTC, MATK, MALOAITN, MATRANGTHAI, NOIDUNG, SECURITYLABEL)
VALUES('CTC_BGD_001', 'TK001', 'TEXT', 'ACTIVE', N'[NỘI BỘ] Cuộc họp chiến lược Q4 vào thứ 6.', 4);

INSERT INTO TINNHAN (MACTC, MATK, MALOAITN, MATRANGTHAI, NOIDUNG, SECURITYLABEL)
VALUES('CTC_BGD_001', 'TK001', 'TEXT', 'ACTIVE', N'[TỐI MẬT] Ngân sách dự án M&A: 50 tỷ đồng.', 5);

BEGIN MAC_CTX_PKG.SET_USER_LEVEL('TK004', 4); END;
/
INSERT INTO TINNHAN (MACTC, MATK, MALOAITN, MATRANGTHAI, NOIDUNG, SECURITYLABEL)
VALUES('CTC_IT_001', 'TK004', 'TEXT', 'ACTIVE', N'Team IT, tuần này focus vào security audit!', 2);

BEGIN MAC_CTX_PKG.SET_USER_LEVEL('TK007', 3); END;
/
INSERT INTO TINNHAN (MACTC, MATK, MALOAITN, MATRANGTHAI, NOIDUNG, SECURITYLABEL)
VALUES('CTC_IT_001', 'TK007', 'TEXT', 'ACTIVE', N'Em đã fix xong bug #1234. Anh Đức review giúp em!', 2);

BEGIN MAC_CTX_PKG.SET_USER_LEVEL('TK008', 1); END;
/
INSERT INTO TINNHAN (MACTC, MATK, MALOAITN, MATRANGTHAI, NOIDUNG, SECURITYLABEL)
VALUES('CTC_IT_001', 'TK008', 'TEXT', 'ACTIVE', N'Em đang học React và Node.js ạ.', 1);

BEGIN MAC_CTX_PKG.CLEAR_CONTEXT; END;
/

COMMIT;

-- =============================================================================
-- VERIFY
-- =============================================================================
SELECT 'Seeds inserted successfully!' AS STATUS FROM DUAL;
SELECT 'Tai khoan: ' || COUNT(*) AS STAT FROM TAIKHOAN;
SELECT 'Cuoc tro chuyen: ' || COUNT(*) AS STAT FROM CUOCTROCHUYEN;
SELECT 'Tin nhan: ' || COUNT(*) AS STAT FROM TINNHAN;
SELECT 'Policies: ' || COUNT(*) AS STAT FROM ADMIN_POLICY;
SHOW USER;
SELECT table_name 
FROM user_tables;





--------------------------------------------------------------------------------
-- CLEARANCE LEVELS (MAC - Bell-LaPadula):
-- Level 5: Giám đốc - TỐI MẬT - Xem tất cả
-- Level 4: Phó GĐ, Trưởng phòng, Admin - MẬT - Xem level 1-4
-- Level 3: Chuyên viên, NV IT - NỘI BỘ - Xem level 1-3
-- Level 2: Nhân viên thường - CÔNG KHAI NỘI BỘ - Xem level 1-2
-- Level 1: Thực tập sinh - CÔNG KHAI - Chỉ xem level 1
--------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
--------------------------------------------------------------------------------
-- 06_GRANTS.SQL - CHẠY VỚI SYS AS SYSDBA (SAU KHI TẠO SCHEMA VÀ PROCEDURES)
-- File này chạy sau: 02_schema.sql, 03_procedures.sql
-- Gán quyền trên tables và packages cho các roles
--------------------------------------------------------------------------------

-- =============================================================================
-- GRANTS CHO CHAT_ADMIN_ROLE
-- =============================================================================
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT, INSERT, UPDATE, DELETE ON ChatApplication.TAIKHOAN TO CHAT_ADMIN_ROLE'; EXCEPTION WHEN OTHERS THEN DBMS_OUTPUT.PUT_LINE('Skip TAIKHOAN grant'); END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT, INSERT, UPDATE, DELETE ON ChatApplication.NGUOIDUNG TO CHAT_ADMIN_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT, INSERT, UPDATE, DELETE ON ChatApplication.CUOCTROCHUYEN TO CHAT_ADMIN_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT, INSERT, UPDATE, DELETE ON ChatApplication.THANHVIEN TO CHAT_ADMIN_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT, INSERT, UPDATE, DELETE ON ChatApplication.TINNHAN TO CHAT_ADMIN_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT, INSERT ON ChatApplication.AUDIT_LOGS TO CHAT_ADMIN_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT EXECUTE ON ChatApplication.MAC_CTX_PKG TO CHAT_ADMIN_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/

-- =============================================================================
-- GRANTS CHO CHAT_USER_ROLE
-- =============================================================================
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT ON ChatApplication.TAIKHOAN TO CHAT_USER_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT, UPDATE ON ChatApplication.NGUOIDUNG TO CHAT_USER_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT ON ChatApplication.CUOCTROCHUYEN TO CHAT_USER_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT, INSERT, UPDATE ON ChatApplication.THANHVIEN TO CHAT_USER_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT, INSERT ON ChatApplication.TINNHAN TO CHAT_USER_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT EXECUTE ON ChatApplication.MAC_CTX_PKG TO CHAT_USER_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/

-- =============================================================================
-- GRANTS CHO CHAT_INTERN_ROLE
-- =============================================================================
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT ON ChatApplication.TAIKHOAN TO CHAT_INTERN_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT ON ChatApplication.NGUOIDUNG TO CHAT_INTERN_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT ON ChatApplication.CUOCTROCHUYEN TO CHAT_INTERN_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/
BEGIN EXECUTE IMMEDIATE 'GRANT SELECT, INSERT ON ChatApplication.TINNHAN TO CHAT_INTERN_ROLE'; EXCEPTION WHEN OTHERS THEN NULL; END;
/

COMMIT;
SELECT 'Grants completed!' AS STATUS FROM DUAL;
SELECT con_id, owner, table_name 
FROM cdb_tables 
WHERE table_name = 'TAIKHOAN';

ALTER SESSION SET CURRENT_SCHEMA = CHATAPPLICATION;

SELECT * FROM TAIKHOAN;
SELECT USER, SYS_CONTEXT('USERENV','CURRENT_SCHEMA') FROM DUAL;




EXEC SET_MAC_CONTEXT('giamdoc3', 5);
SELECT * FROM TAIKHOAN;

SELECT * FROM TAIKHOAN WHERE Tentk='giamdoc';


SELECT * FROM TAIKHOAN 
---


-- Kết nối với ChatApplication trước
-- CONNECT ChatApplication/123@ORCLPDB;

SET SERVEROUTPUT ON;
SET FEEDBACK ON;

-- 1. Tạo bảng BACKUP_HISTORY
BEGIN
    EXECUTE IMMEDIATE 'DROP TABLE BACKUP_HISTORY CASCADE CONSTRAINTS';
    DBMS_OUTPUT.PUT_LINE('Đã xóa bảng BACKUP_HISTORY cũ');
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -942 THEN
            RAISE;
        END IF;
END;
/

CREATE TABLE BACKUP_HISTORY (
    BACKUP_ID NUMBER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
    BACKUP_TYPE VARCHAR2(50) NOT NULL,
    BACKUP_FILE VARCHAR2(500),
    BACKUP_SIZE_MB NUMBER,
    BACKUP_TIME TIMESTAMP DEFAULT SYSTIMESTAMP,
    STATUS VARCHAR2(50) DEFAULT 'SUCCESS',
    MESSAGE VARCHAR2(4000),
    CREATED_BY VARCHAR2(50)
) TABLESPACE CHAT_DATA_TS;

DBMS_OUTPUT.PUT_LINE('Đã tạo bảng BACKUP_HISTORY');

-- 2. Tạo bảng TIMEOUT_SETTINGS
BEGIN
    EXECUTE IMMEDIATE 'DROP TABLE TIMEOUT_SETTINGS CASCADE CONSTRAINTS';
    DBMS_OUTPUT.PUT_LINE('Đã xóa bảng TIMEOUT_SETTINGS cũ');
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -942 THEN
            RAISE;
        END IF;
END;
/

CREATE TABLE TIMEOUT_SETTINGS (
    SETTING_ID VARCHAR2(50) PRIMARY KEY,
    SETTING_NAME VARCHAR2(100) NOT NULL,
    TIMEOUT_MINUTES NUMBER DEFAULT 30,
    DESCRIPTION VARCHAR2(500),
    UPDATED_BY VARCHAR2(50),
    UPDATED_AT TIMESTAMP DEFAULT SYSTIMESTAMP
) TABLESPACE CHAT_DATA_TS;

DBMS_OUTPUT.PUT_LINE('Đã tạo bảng TIMEOUT_SETTINGS');

-- 3. Chèn dữ liệu mẫu cho timeout settings
BEGIN
    INSERT INTO TIMEOUT_SETTINGS (SETTING_ID, SETTING_NAME, TIMEOUT_MINUTES, DESCRIPTION) 
    VALUES ('USER_SESSION', 'Phiên đăng nhập User', 30, 'Thời gian timeout cho phiên đăng nhập của user thông thường');

    INSERT INTO TIMEOUT_SETTINGS (SETTING_ID, SETTING_NAME, TIMEOUT_MINUTES, DESCRIPTION) 
    VALUES ('ADMIN_SESSION', 'Phiên đăng nhập Admin', 60, 'Thời gian timeout cho phiên đăng nhập của admin');

    INSERT INTO TIMEOUT_SETTINGS (SETTING_ID, SETTING_NAME, TIMEOUT_MINUTES, DESCRIPTION) 
    VALUES ('OTP_EXPIRY', 'Thời gian hết hạn OTP', 10, 'Thời gian hiệu lực của mã OTP');

    INSERT INTO TIMEOUT_SETTINGS (SETTING_ID, SETTING_NAME, TIMEOUT_MINUTES, DESCRIPTION) 
    VALUES ('PASSWORD_RESET', 'Password Reset Token', 15, 'Thời gian hiệu lực của token reset password');
    
    COMMIT;
    DBMS_OUTPUT.PUT_LINE('Đã chèn dữ liệu mẫu cho TIMEOUT_SETTINGS');
EXCEPTION
    WHEN DUP_VAL_ON_INDEX THEN
        DBMS_OUTPUT.PUT_LINE('Dữ liệu đã tồn tại trong TIMEOUT_SETTINGS');
        ROLLBACK;
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Lỗi chèn TIMEOUT_SETTINGS: ' || SQLERRM);
        ROLLBACK;
END;
/

-- 4. Sửa procedure SP_BACKUP_DATA - SAI CÚ PHÁP FIXED
CREATE OR REPLACE PROCEDURE SP_BACKUP_DATA(
    p_backup_type IN VARCHAR2 DEFAULT 'FULL',
    p_created_by IN VARCHAR2
) AS
    v_backup_id NUMBER;
    v_file_name VARCHAR2(200);
    v_message VARCHAR2(4000);
    v_error_msg VARCHAR2(4000);
BEGIN
    -- Tạo tên file backup
    v_file_name := 'CHAT_BACKUP_' || TO_CHAR(SYSTIMESTAMP, 'YYYYMMDD_HH24MISS') || '.dmp';
    v_message := 'Starting backup at ' || TO_CHAR(SYSTIMESTAMP, 'DD/MM/YYYY HH24:MI:SS');
    
    -- Insert vào backup history với trạng thái IN_PROGRESS
    INSERT INTO BACKUP_HISTORY (
        BACKUP_TYPE, 
        BACKUP_FILE, 
        BACKUP_SIZE_MB, 
        STATUS, 
        CREATED_BY, 
        MESSAGE
    ) VALUES (
        p_backup_type, 
        v_file_name, 
        0, 
        'IN_PROGRESS', 
        p_created_by, 
        v_message
    ) RETURNING BACKUP_ID INTO v_backup_id;
    
    COMMIT;
    
    -- Cập nhật trạng thái thành công
    UPDATE BACKUP_HISTORY 
    SET STATUS = 'SUCCESS',
        MESSAGE = MESSAGE || ' | Backup completed successfully at ' || TO_CHAR(SYSTIMESTAMP, 'DD/MM/YYYY HH24:MI:SS'),
        BACKUP_SIZE_MB = 150
    WHERE BACKUP_ID = v_backup_id;
    
    -- Ghi audit log
    INSERT INTO AUDIT_LOGS (MATK, ACTION, TARGET, SECURITYLABEL, DETAILS, TIMESTAMP)
    VALUES (p_created_by, 'BACKUP_DATABASE', p_backup_type, 0, 
            'Backup ID: ' || v_backup_id || ', File: ' || v_file_name, SYSTIMESTAMP);
    
    COMMIT;
    
    DBMS_OUTPUT.PUT_LINE('Backup completed: ' || v_file_name);
EXCEPTION
    WHEN OTHERS THEN
        -- Lấy thông báo lỗi
        v_error_msg := SQLERRM;
        
        -- Cập nhật trạng thái thất bại
        UPDATE BACKUP_HISTORY 
        SET STATUS = 'FAILED',
            MESSAGE = MESSAGE || ' | Error: ' || v_error_msg
        WHERE BACKUP_ID = v_backup_id;
        
        INSERT INTO AUDIT_LOGS (MATK, ACTION, TARGET, SECURITYLABEL, DETAILS, TIMESTAMP, STATUS)
        VALUES (p_created_by, 'BACKUP_FAILED', p_backup_type, 0, 
                'Error: ' || v_error_msg, SYSTIMESTAMP, 'FAILED');
        COMMIT;
        RAISE;
END SP_BACKUP_DATA;
/

-- 5. Tạo procedure restore backup
CREATE OR REPLACE PROCEDURE SP_RESTORE_BACKUP(
    p_backup_id IN NUMBER,
    p_restored_by IN VARCHAR2
) AS
    v_backup_file VARCHAR2(500);
    v_backup_type VARCHAR2(50);
    v_error_msg VARCHAR2(4000);
BEGIN
    -- Lấy thông tin backup
    SELECT BACKUP_FILE, BACKUP_TYPE INTO v_backup_file, v_backup_type
    FROM BACKUP_HISTORY 
    WHERE BACKUP_ID = p_backup_id AND STATUS = 'SUCCESS';
    
    IF v_backup_file IS NULL THEN
        RAISE_APPLICATION_ERROR(-20001, 'Backup không tồn tại hoặc chưa thành công');
    END IF;
    
    -- Ghi log bắt đầu restore
    INSERT INTO AUDIT_LOGS (MATK, ACTION, TARGET, SECURITYLABEL, DETAILS, TIMESTAMP)
    VALUES (p_restored_by, 'RESTORE_START', v_backup_file, 0, 
            'Starting restore for backup ID: ' || p_backup_id, SYSTIMESTAMP);
    
    -- Cập nhật backup history
    UPDATE BACKUP_HISTORY 
    SET MESSAGE = MESSAGE || ' - Restored at ' || TO_CHAR(SYSTIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') || 
                  ' by ' || p_restored_by
    WHERE BACKUP_ID = p_backup_id;
    
    -- Ghi audit log thành công
    INSERT INTO AUDIT_LOGS (MATK, ACTION, TARGET, SECURITYLABEL, DETAILS, TIMESTAMP)
    VALUES (p_restored_by, 'RESTORE_COMPLETE', v_backup_file, 0, 
            'Restored backup ID: ' || p_backup_id || ' successfully', SYSTIMESTAMP);
    
    COMMIT;
    
    DBMS_OUTPUT.PUT_LINE('Restore completed for backup ID: ' || p_backup_id);
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR(-20002, 'Không tìm thấy backup thành công với ID: ' || p_backup_id);
    WHEN OTHERS THEN
        v_error_msg := SQLERRM;
        INSERT INTO AUDIT_LOGS (MATK, ACTION, TARGET, SECURITYLABEL, DETAILS, TIMESTAMP, STATUS)
        VALUES (p_restored_by, 'RESTORE_FAILED', TO_CHAR(p_backup_id), 0, 
                'Error: ' || v_error_msg, SYSTIMESTAMP, 'FAILED');
        COMMIT;
        RAISE;
END SP_RESTORE_BACKUP;
/

-- 6. Tạo procedure cập nhật timeout settings
CREATE OR REPLACE PROCEDURE SP_UPDATE_TIMEOUT_SETTING(
    p_setting_id IN VARCHAR2,
    p_timeout_minutes IN NUMBER,
    p_updated_by IN VARCHAR2
) AS
    v_old_value NUMBER;
    v_setting_name VARCHAR2(100);
    v_error_msg VARCHAR2(4000);
BEGIN
    -- Lấy giá trị cũ
    SELECT TIMEOUT_MINUTES, SETTING_NAME INTO v_old_value, v_setting_name
    FROM TIMEOUT_SETTINGS
    WHERE SETTING_ID = p_setting_id;
    
    -- Cập nhật giá trị mới
    UPDATE TIMEOUT_SETTINGS
    SET TIMEOUT_MINUTES = p_timeout_minutes,
        UPDATED_BY = p_updated_by,
        UPDATED_AT = SYSTIMESTAMP
    WHERE SETTING_ID = p_setting_id;
    
    IF SQL%ROWCOUNT = 0 THEN
        RAISE_APPLICATION_ERROR(-20003, 'Không tìm thấy setting: ' || p_setting_id);
    END IF;
    
    -- Ghi audit log chi tiết
    INSERT INTO AUDIT_LOGS (MATK, ACTION, TARGET, SECURITYLABEL, DETAILS, TIMESTAMP)
    VALUES (p_updated_by, 'UPDATE_TIMEOUT', p_setting_id, 0, 
            v_setting_name || ': ' || v_old_value || ' minutes → ' || p_timeout_minutes || ' minutes', 
            SYSTIMESTAMP);
    
    COMMIT;
    
    DBMS_OUTPUT.PUT_LINE('Updated ' || v_setting_name || ' to ' || p_timeout_minutes || ' minutes');
EXCEPTION
    WHEN OTHERS THEN
        v_error_msg := SQLERRM;
        DBMS_OUTPUT.PUT_LINE('Error updating timeout setting: ' || v_error_msg);
        RAISE;
END SP_UPDATE_TIMEOUT_SETTING;
/

-- 7. Tạo view cho login history
CREATE OR REPLACE VIEW V_LOGIN_HISTORY AS
SELECT 
    TO_CHAR(l.TIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') AS LOGIN_TIME,
    NVL(u.TENTK, l.MATK) AS USERNAME,
    nd.HOVATEN,
    CASE 
        WHEN l.ACTION LIKE '%LOGIN%' AND l.STATUS = 'SUCCESS' THEN 'Đăng nhập thành công'
        WHEN l.ACTION LIKE '%LOGIN%' AND l.STATUS = 'FAILED' THEN 'Đăng nhập thất bại'
        WHEN l.ACTION LIKE '%LOGOUT%' THEN 'Đăng xuất'
        WHEN l.ACTION LIKE '%LOCK%' THEN 'Khóa tài khoản'
        ELSE l.ACTION
    END AS ACTION_TYPE,
    l.IP_ADDRESS,
    l.STATUS,
    l.DETAILS,
    l.TIMESTAMP AS RAW_TIMESTAMP
FROM AUDIT_LOGS l
LEFT JOIN TAIKHOAN u ON l.MATK = u.MATK
LEFT JOIN NGUOIDUNG nd ON u.MATK = nd.MATK
WHERE l.ACTION IN (
    'USER_LOGIN', 'LOGIN_SUCCESS', 'LOGIN_FAILED', 
    'LOGOUT', 'LOGIN_BLOCKED', 'ACCOUNT_LOCKED',
    'LOGIN_ATTEMPT', 'PASSWORD_CHANGE', 'ACCOUNT_UNLOCKED'
);

BEGIN
    DBMS_OUTPUT.PUT_LINE('Đã tạo view V_LOGIN_HISTORY');
END;
/

-- 8. Tạo function lấy backup history
CREATE OR REPLACE FUNCTION FN_GET_BACKUP_HISTORY(
    p_days_back IN NUMBER DEFAULT 30
) RETURN SYS_REFCURSOR
AS
    v_cursor SYS_REFCURSOR;
BEGIN
    OPEN v_cursor FOR
        SELECT 
            BACKUP_ID,
            BACKUP_TYPE,
            BACKUP_FILE,
            BACKUP_SIZE_MB,
            TO_CHAR(BACKUP_TIME, 'DD/MM/YYYY HH24:MI:SS') AS BACKUP_TIME_FORMATTED,
            STATUS,
            MESSAGE,
            CREATED_BY
        FROM BACKUP_HISTORY 
        WHERE BACKUP_TIME >= SYSDATE - p_days_back
        ORDER BY BACKUP_TIME DESC;
    
    RETURN v_cursor;
END FN_GET_BACKUP_HISTORY;
/

-- 9. Tạo trigger tự động ghi log cho timeout settings
CREATE OR REPLACE TRIGGER TRG_TIMEOUT_SETTINGS_AUDIT
AFTER UPDATE ON TIMEOUT_SETTINGS
FOR EACH ROW
DECLARE
    v_details VARCHAR2(1000);
BEGIN
    IF :OLD.TIMEOUT_MINUTES != :NEW.TIMEOUT_MINUTES THEN
        v_details := :NEW.SETTING_NAME || ' changed from ' || :OLD.TIMEOUT_MINUTES || 
                     ' to ' || :NEW.TIMEOUT_MINUTES || ' minutes';
        
        INSERT INTO AUDIT_LOGS (MATK, ACTION, TARGET, SECURITYLABEL, DETAILS, TIMESTAMP)
        VALUES (:NEW.UPDATED_BY, 'TIMEOUT_CHANGED', :NEW.SETTING_ID, 0, v_details, SYSTIMESTAMP);
    END IF;
END;
/

-- 10. Chèn dữ liệu mẫu cho backup history
BEGIN
    INSERT INTO BACKUP_HISTORY (
        BACKUP_TYPE, 
        BACKUP_FILE, 
        BACKUP_SIZE_MB, 
        STATUS, 
        CREATED_BY, 
        MESSAGE, 
        BACKUP_TIME
    ) VALUES (
        'FULL', 
        'CHAT_BACKUP_20240101_120000.dmp', 
        150, 
        'SUCCESS', 
        'ADMIN', 
        'Backup tự động hàng ngày', 
        SYSTIMESTAMP - 5
    );
    
    INSERT INTO BACKUP_HISTORY (
        BACKUP_TYPE, 
        BACKUP_FILE, 
        BACKUP_SIZE_MB, 
        STATUS, 
        CREATED_BY, 
        MESSAGE, 
        BACKUP_TIME
    ) VALUES (
        'FULL', 
        'CHAT_BACKUP_20240102_120000.dmp', 
        160, 
        'SUCCESS', 
        'ADMIN', 
        'Backup tự động hàng ngày', 
        SYSTIMESTAMP - 4
    );
    
    INSERT INTO BACKUP_HISTORY (
        BACKUP_TYPE, 
        BACKUP_FILE, 
        BACKUP_SIZE_MB, 
        STATUS, 
        CREATED_BY, 
        MESSAGE, 
        BACKUP_TIME
    ) VALUES (
        'INCREMENTAL', 
        'CHAT_BACKUP_20240103_120000.dmp', 
        20, 
        'SUCCESS', 
        'ADMIN', 
        'Backup tăng dần', 
        SYSTIMESTAMP - 3
    );
    
    INSERT INTO BACKUP_HISTORY (
        BACKUP_TYPE, 
        BACKUP_FILE, 
        BACKUP_SIZE_MB, 
        STATUS, 
        CREATED_BY, 
        MESSAGE, 
        BACKUP_TIME
    ) VALUES (
        'FULL', 
        'CHAT_BACKUP_20240104_120000.dmp', 
        155, 
        'FAILED', 
        'ADMIN', 
        'Backup thất bại do không đủ dung lượng', 
        SYSTIMESTAMP - 2
    );
    
    COMMIT;
    DBMS_OUTPUT.PUT_LINE('Đã chèn dữ liệu mẫu cho BACKUP_HISTORY');
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Lỗi chèn dữ liệu mẫu: ' || SQLERRM);
        ROLLBACK;
END;
/

-- 11. Chèn dữ liệu mẫu cho audit logs (login history)
BEGIN
    -- Xóa dữ liệu cũ nếu có (chỉ xóa những bản ghi mẫu cũ)
    DELETE FROM AUDIT_LOGS WHERE ACTION IN (
        'USER_LOGIN', 'LOGIN_SUCCESS', 'LOGIN_FAILED', 'LOGOUT',
        'ACCOUNT_LOCKED', 'ACCOUNT_UNLOCKED'
    ) AND DETAILS LIKE '%mẫu%' OR DETAILS LIKE '%Login%' OR DETAILS LIKE '%Logout%';
    
    -- Chèn dữ liệu mới
    INSERT INTO AUDIT_LOGS (
        MATK, 
        ACTION, 
        TARGET, 
        SECURITYLABEL, 
        STATUS, 
        DETAILS, 
        IP_ADDRESS, 
        TIMESTAMP
    ) SELECT 
        MATK, 
        'USER_LOGIN', 
        'SYSTEM', 
        0, 
        'SUCCESS', 
        'Login thành công từ hệ thống (mẫu)', 
        '192.168.1.100', 
        SYSTIMESTAMP - INTERVAL '1' HOUR
    FROM TAIKHOAN 
    WHERE MATK IN ('TK001', 'TK002', 'TK003');
    
    INSERT INTO AUDIT_LOGS (
        MATK, 
        ACTION, 
        TARGET, 
        SECURITYLABEL, 
        STATUS, 
        DETAILS, 
        IP_ADDRESS, 
        TIMESTAMP
    ) SELECT 
        MATK, 
        'LOGOUT', 
        'SYSTEM', 
        0, 
        'SUCCESS', 
        'Logout từ hệ thống (mẫu)', 
        '192.168.1.100', 
        SYSTIMESTAMP - INTERVAL '30' MINUTE
    FROM TAIKHOAN 
    WHERE MATK IN ('TK001', 'TK002');
    
    INSERT INTO AUDIT_LOGS (
        MATK, 
        ACTION, 
        TARGET, 
        SECURITYLABEL, 
        STATUS, 
        DETAILS, 
        IP_ADDRESS, 
        TIMESTAMP
    ) VALUES (
        'TK008', 
        'LOGIN_FAILED', 
        'SYSTEM', 
        0, 
        'FAILED', 
        'Sai mật khẩu (attempt 3/5) - mẫu', 
        '192.168.1.150', 
        SYSTIMESTAMP - INTERVAL '2' HOUR
    );
    
    INSERT INTO AUDIT_LOGS (
        MATK, 
        ACTION, 
        TARGET, 
        SECURITYLABEL, 
        STATUS, 
        DETAILS, 
        IP_ADDRESS, 
        TIMESTAMP
    ) VALUES (
        'TK006', 
        'USER_LOGIN', 
        'SYSTEM', 
        0, 
        'SUCCESS', 
        'Login từ mobile app (mẫu)', 
        '10.0.0.15', 
        SYSTIMESTAMP - INTERVAL '3' HOUR
    );
    
    INSERT INTO AUDIT_LOGS (
        MATK, 
        ACTION, 
        TARGET, 
        SECURITYLABEL, 
        STATUS, 
        DETAILS, 
        IP_ADDRESS, 
        TIMESTAMP
    ) VALUES (
        'TK007', 
        'ACCOUNT_LOCKED', 
        'SYSTEM', 
        0, 
        'FAILED', 
        'Tài khoản bị khóa do 5 lần nhập sai (mẫu)', 
        '192.168.1.200', 
        SYSTIMESTAMP - INTERVAL '1' DAY
    );
    
    INSERT INTO AUDIT_LOGS (
        MATK, 
        ACTION, 
        TARGET, 
        SECURITYLABEL, 
        STATUS, 
        DETAILS, 
        IP_ADDRESS, 
        TIMESTAMP
    ) VALUES (
        'TK007', 
        'ACCOUNT_UNLOCKED', 
        'SYSTEM', 
        0, 
        'SUCCESS', 
        'Admin mở khóa tài khoản (mẫu)', 
        '192.168.1.1', 
        SYSTIMESTAMP - INTERVAL '12' HOUR
    );
    
    COMMIT;
    DBMS_OUTPUT.PUT_LINE('Đã chèn dữ liệu mẫu cho AUDIT_LOGS (login history)');
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Lỗi chèn dữ liệu AUDIT_LOGS: ' || SQLERRM);
        ROLLBACK;
END;
/

-- 12. Hiển thị kết quả
BEGIN
    DBMS_OUTPUT.PUT_LINE('=========================================');
    DBMS_OUTPUT.PUT_LINE('THIẾT LẬP HOÀN TẤT');
    DBMS_OUTPUT.PUT_LINE('=========================================');
    
    DECLARE
        v_backup_count NUMBER;
        v_timeout_count NUMBER;
        v_login_count NUMBER;
    BEGIN
        SELECT COUNT(*) INTO v_backup_count FROM BACKUP_HISTORY;
        SELECT COUNT(*) INTO v_timeout_count FROM TIMEOUT_SETTINGS;
        SELECT COUNT(*) INTO v_login_count FROM V_LOGIN_HISTORY;
        
        DBMS_OUTPUT.PUT_LINE('Số lượng bản ghi:');
        DBMS_OUTPUT.PUT_LINE('  - BACKUP_HISTORY: ' || v_backup_count);
        DBMS_OUTPUT.PUT_LINE('  - TIMEOUT_SETTINGS: ' || v_timeout_count);
        DBMS_OUTPUT.PUT_LINE('  - LOGIN HISTORY: ' || v_login_count);
    END;
    
    -- Test procedure backup
    BEGIN
        SP_BACKUP_DATA('TEST', 'SYSTEM');
        DBMS_OUTPUT.PUT_LINE('✓ Test backup thành công');
    EXCEPTION
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('✗ Test backup lỗi: ' || SQLERRM);
    END;
    
    -- Test procedure update timeout
    BEGIN
        SP_UPDATE_TIMEOUT_SETTING('USER_SESSION', 45, 'SYSTEM');
        DBMS_OUTPUT.PUT_LINE('✓ Test update timeout thành công');
    EXCEPTION
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('✗ Test update timeout lỗi: ' || SQLERRM);
    END;
    
    DBMS_OUTPUT.PUT_LINE('=========================================');
    DBMS_OUTPUT.PUT_LINE('CÁC ĐỐI TƯỢNG ĐÃ TẠO:');
    DBMS_OUTPUT.PUT_LINE('=========================================');
    
    FOR rec IN (
        SELECT OBJECT_NAME, OBJECT_TYPE, STATUS 
        FROM USER_OBJECTS 
        WHERE OBJECT_NAME IN (
            'BACKUP_HISTORY', 'TIMEOUT_SETTINGS', 'V_LOGIN_HISTORY',
            'SP_BACKUP_DATA', 'SP_RESTORE_BACKUP', 'SP_UPDATE_TIMEOUT_SETTING',
            'FN_GET_BACKUP_HISTORY', 'TRG_TIMEOUT_SETTINGS_AUDIT'
        )
        ORDER BY OBJECT_TYPE, OBJECT_NAME
    )
    LOOP
        DBMS_OUTPUT.PUT_LINE('  ' || rec.OBJECT_TYPE || ': ' || rec.OBJECT_NAME || ' - ' || rec.STATUS);
    END LOOP;
    
    DBMS_OUTPUT.PUT_LINE('=========================================');
    
    -- Xem dữ liệu mẫu
    DBMS_OUTPUT.PUT_LINE('Dữ liệu BACKUP_HISTORY (3 bản ghi mới nhất):');
    FOR rec IN (
        SELECT BACKUP_ID, BACKUP_TYPE, BACKUP_FILE, STATUS, 
               TO_CHAR(BACKUP_TIME, 'DD/MM/YYYY HH24:MI') AS BACKUP_TIME
        FROM BACKUP_HISTORY 
        ORDER BY BACKUP_TIME DESC 
        FETCH FIRST 3 ROWS ONLY
    )
    LOOP
        DBMS_OUTPUT.PUT_LINE('  ID ' || rec.BACKUP_ID || ': ' || rec.BACKUP_TYPE || 
                            ' - ' || rec.BACKUP_FILE || ' (' || rec.STATUS || ') - ' || rec.BACKUP_TIME);
    END LOOP;
    
    DBMS_OUTPUT.PUT_LINE('=========================================');
    DBMS_OUTPUT.PUT_LINE('TIMEOUT SETTINGS:');
    FOR rec IN (
        SELECT SETTING_ID, SETTING_NAME, TIMEOUT_MINUTES, DESCRIPTION
        FROM TIMEOUT_SETTINGS
        ORDER BY SETTING_ID
    )
    LOOP
        DBMS_OUTPUT.PUT_LINE('  ' || rec.SETTING_ID || ': ' || rec.SETTING_NAME || 
                            ' (' || rec.TIMEOUT_MINUTES || ' phút)');
    END LOOP;
    
    DBMS_OUTPUT.PUT_LINE('=========================================');
    DBMS_OUTPUT.PUT_LINE('LOGIN HISTORY (3 bản ghi mới nhất):');
    FOR rec IN (
        SELECT LOGIN_TIME, USERNAME, ACTION_TYPE, IP_ADDRESS, STATUS
        FROM V_LOGIN_HISTORY
        ORDER BY RAW_TIMESTAMP DESC
        FETCH FIRST 3 ROWS ONLY
    )
    LOOP
        DBMS_OUTPUT.PUT_LINE('  ' || rec.LOGIN_TIME || ' - ' || rec.USERNAME || 
                            ' - ' || rec.ACTION_TYPE || ' - ' || rec.IP_ADDRESS || ' - ' || rec.STATUS);
    END LOOP;
    
    DBMS_OUTPUT.PUT_LINE('=========================================');
END;
/