CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

CREATE TABLE "Employees" (
    "EmployeeId" serial NOT NULL,
    "FullName" varchar(250) NOT NULL,
    "EmpCode" varchar(10) NULL,
    position varchar(100) NULL,
    "OfficeLocation" varchar(100) NULL,
    CONSTRAINT "PK_Employees" PRIMARY KEY ("EmployeeId")
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191102052314_FirstMigration', '2.2.6-servicing-10079');

ALTER TABLE "Employees" ADD "Phone" varchar(20) NULL;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191102151603_PhoneMigration', '2.2.6-servicing-10079');

ALTER TABLE "Employees" ADD "Active" boolean NOT NULL DEFAULT TRUE;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191102154204_ActiveMigration', '2.2.6-servicing-10079');

