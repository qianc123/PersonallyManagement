/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     2016/6/24 13:45:00                           */
/*==============================================================*/
create database PersonnelManagementSystemSQL
go

use PersonnelManagementSystemSQL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblDepartment') and o.name = 'FK_TBLDEPAR_REFERENCE_TBLEMPL_bumenyuanggong')
alter table tblDepartment
   drop constraint FK_TBLDEPAR_REFERENCE_TBLEMPL_bumenyuanggong
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblEmployee') and o.name = 'FK_TBLDEPAR_REFERENCE_TBLEMPL_bumenyuanggong1')
alter table tblEmployee
   drop constraint FK_TBLDEPAR_REFERENCE_TBLEMPL_bumenyuanggong1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblEmployeeAttendanceRecord') and o.name = 'FK_TBLEMPLO_REFERENCE_TBLEMPLO_yuanggongtokaoqing')
alter table tblEmployeeAttendanceRecord
   drop constraint FK_TBLEMPLO_REFERENCE_TBLEMPLO_yuanggongtokaoqing
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblEmployeeAttendanceRecord') and o.name = 'FK_TBLEMPLO_REFERENCE_TBLEMPL_yuangongtokaoqing1')
alter table tblEmployeeAttendanceRecord
   drop constraint FK_TBLEMPLO_REFERENCE_TBLEMPL_yuangongtokaoqing1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblEmployeeLeave') and o.name = 'FK_TBLEMPLO_REFERENCE_TBLEMPLO')
alter table tblEmployeeLeave
   drop constraint FK_TBLEMPLO_REFERENCE_TBLEMPLO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblEmployeeLeave') and o.name = 'FK_TBLEMPLO_REFERENCE_TBLEMPL_yuanggongtoqingjia')
alter table tblEmployeeLeave
   drop constraint FK_TBLEMPLO_REFERENCE_TBLEMPL_yuanggongtoqingjia
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblEmployeeSalary') and o.name = 'FK_TBLEMPLO_REFERENCE_TBLEMPL_yuanggongxinzhi')
alter table tblEmployeeSalary
   drop constraint FK_TBLEMPLO_REFERENCE_TBLEMPL_yuanggongxinzhi
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblOvertime') and o.name = 'FK_TBLOVERT_REFERENCE_TBLEMPL_yuanggongjiaban')
alter table tblOvertime
   drop constraint FK_TBLOVERT_REFERENCE_TBLEMPL_yuanggongjiaban
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblOvertime') and o.name = 'FK_TBLOVERT_REFERENCE_TBLOVERT_jiabanleixintojiaban')
alter table tblOvertime
   drop constraint FK_TBLOVERT_REFERENCE_TBLOVERT_jiabanleixintojiaban
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblOvertime') and o.name = 'FK_TBLOVERT_REFERENCE_TBLEMPL_yuanggongjiaban1')
alter table tblOvertime
   drop constraint FK_TBLOVERT_REFERENCE_TBLEMPL_yuanggongjiaban1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblWorkEvaluation') and o.name = 'FK_TBLWORKE_REFERENCE_TBLEMPL_yuangongyeji1')
alter table tblWorkEvaluation
   drop constraint FK_TBLWORKE_REFERENCE_TBLEMPL_yuangongyeji1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tblWorkEvaluation') and o.name = 'FK_TBLWORKE_REFERENCE_TBLEMPL_yuanggongyeji')
alter table tblWorkEvaluation
   drop constraint FK_TBLWORKE_REFERENCE_TBLEMPL_yuanggongyeji
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tblDepartment')
            and   type = 'U')
   drop table tblDepartment
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tblEmployee')
            and   type = 'U')
   drop table tblEmployee
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tblEmployeeAttendanceRecord')
            and   type = 'U')
   drop table tblEmployeeAttendanceRecord
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tblEmployeeLeave')
            and   type = 'U')
   drop table tblEmployeeLeave
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tblEmployeeSalary')
            and   type = 'U')
   drop table tblEmployeeSalary
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tblOvertime')
            and   type = 'U')
   drop table tblOvertime
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tblOvertimeType')
            and   type = 'U')
   drop table tblOvertimeType
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tblSystemEvent')
            and   type = 'U')
   drop table tblSystemEvent
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tblSystemLayout')
            and   type = 'U')
   drop table tblSystemLayout
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tblVacation')
            and   type = 'U')
   drop table tblVacation
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tblWorkEvaluation')
            and   type = 'U')
   drop table tblWorkEvaluation
go

/*==============================================================*/
/* Table: tblDepartment                                         */
/*==============================================================*/
create table tblDepartment (
   departmentId         int                  identity,
   departmentName       varchar(10)          null,
   departmentDescribe   varchar(50)          null,
   employeeId           int                  null,
   constraint PK_TBLDEPARTMENT primary key nonclustered (departmentId)
)
go

/*==============================================================*/
/* Table: tblEmployee                                           */
/*==============================================================*/
create table tblEmployee (
   employeeId           int                  identity,
   employeeName         varchar(50)          not null,
   employeeLoginName    varchar(20)          not null,
   employeeLoginPwd     varchar(20)          not null,
   employeeEmail        varchar(50)          not null,
   departmentId         int                  null,
   employeeBaseSalary   int                  null,
   employeePosition     varchar(50)          null,
   employeePhone        varchar(50)          null,
   employeeDataOfArrive date                 not null,
   employeeSelfInteroduction varchar(200)         null,
   employeeResidueVacations int                  null,
   employeeRank         int                  null,
   employeePicture      image                null,
   constraint PK_TBLEMPLOYEE primary key nonclustered (employeeId),
   constraint PK_TBLEMPLOYEE_yueshu check (employeeName != employeeLoginName)
)
go

/*==============================================================*/
/* Table: tblEmployeeAttendanceRecord                           */
/*==============================================================*/
create table tblEmployeeAttendanceRecord (
   attendanceId         int                  identity,
   employeeId           int                  not null,
   arriveTime           datetime             null,
   recordId             int                  null,
   attendanceType       varchar(4)           not null,
   backAudit            int                  null,
   dateTimes            date                 not null,
   constraint PK_TBLEMPLOYEEATTENDANCERECORD primary key nonclustered (attendanceId),
   constraint PK_TBLEMPLOYEE_ATTENDANCERECORD check (attendanceId != employeeId ),
   constraint PK_TBLEMPLOYEE_ATTENDANCERECORDTYPE check (attendanceType in('迟到','缺勤','早退'))
)
go

/*==============================================================*/
/* Table: tblEmployeeLeave                                      */
/*==============================================================*/
create table tblEmployeeLeave (
   leaveId              int                  identity(100,1),
   employeeId           int                  not null,
   handTime             datetime             not null,
   stratTime            datetime             not null,
   endTime              datetime             not null,
   reason               varchar(100)         null,
   leaveType            int                  null,
   timeHours            float                not null,
   applytStatus         varchar(20)          null,
   auditorId            int                  null,
   reasonOfRefuse       varchar(100)         null,
   constraint PK_TBLEMPLOYEELEAVE primary key nonclustered (leaveId),
   constraint PK_TBLEMPLOYEELEAVE_TIME check (stratTime < endTime),
   constraint PK_TBLEMPLOYEELEAVE_VALUE check (applytStatus in ('已提交','已取消','已批准','已否决'))
)
go

/*==============================================================*/
/* Table: tblEmployeeSalary                                     */
/*==============================================================*/
create table tblEmployeeSalary (
   salaryId             int                  identity,
   employeeId           int                  not null,
   payfoDate            date                 not null,
   overtimeSalary       int                  null,
   cutOfAbsenteeism     int                  null,
   otherSalary          int                  null,
   baseSalary			int					 null,
   constraint PK_TBLEMPLOYEESALARY primary key nonclustered (salaryId)
)
go

/*==============================================================*/
/* Table: tblOvertime                                           */
/*==============================================================*/
create table tblOvertime (
   applyId              int                  identity,
   employeeId           int                  not null,
   evalutorId           int                  null,
   submitTime           date                 not null,
   beginTime            datetime             not null,
   endTime              datetime             not null,
   overtimeReason       varchar(100)         not null,
   applyConditions      varchar(10)          not null,
   overtimeType         int                  null,
   refuseReason         varchar(100)         null,
   timeTours            int                  null,
   constraint PK_TBLOVERTIME primary key nonclustered (applyId),
   constraint PK_TBLOVERTIME_OVERTIME check (beginTime < endTime),
   constraint PK_TBLOVERTIME_CONDITION check (applyconditions in ('已批准','待批准','被拒绝'))
)
go

/*==============================================================*/
/* Table: tblOvertimeType                                       */
/*==============================================================*/
create table tblOvertimeType (
   overtimeType         int                  identity,
   overtimeName         varchar(10)          not null,
   constraint PK_TBLOVERTIMETYPE primary key nonclustered (overtimeType)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '此字段可取值"折算成年假"或"折算成津贴"',
   'user', @CurrentUser, 'table', 'tblOvertimeType', 'column', 'overtimeName'
go

/*==============================================================*/
/* Table: tblSystemEvent                                        */
/*==============================================================*/
create table tblSystemEvent (
   eventId              int                  identity,
   eventTime            date                 not null,
   eventDescribe        varchar(100)         not null,
   constraint PK_TBLSYSTEMEVENT primary key nonclustered (eventId)
)
go

/*==============================================================*/
/* Table: tblSystemLayout                                       */
/*==============================================================*/
create table tblSystemLayout (
   layoutId             int                  identity,
   layoutType           varchar(10)          null,
   layoutName           varchar(50)          not null,
   layoutValue          varchar(50)          null,
   constraint PK_TBLSYSTEMLAYOUT primary key nonclustered (layoutId)
)
go

/*==============================================================*/
/* Table: tblVacation                                           */
/*==============================================================*/
create table tblVacation (
   vacationId           int                  identity,
   vacationTime         date                 not null,
   vacationName         varchar(50)          not null,
   ifNationalVacation   bit                  not null,
   constraint PK_TBLVACATION primary key nonclustered (vacationId)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '此字段只能取值"0"或"1"',
   'user', @CurrentUser, 'table', 'tblVacation', 'column', 'ifNationalVacation'
go

/*==============================================================*/
/* Table: tblWorkEvaluation                                     */
/*==============================================================*/
create table tblWorkEvaluation (
   evaluationId         int                  identity,
   employeeId           int                  not null,
   evalutorsId          int                  null,
   submitTime           datetime             not null,
   particularYear       int                  not null,
   season               int                  not null,
   conditions           int                  null,
   lastEditTime         date                 null,
   selfEvaluationGrade  int                  null,
   evalutorGrade        int                  null,
   selfEvaluation       varchar(200)         null,
   evalutorView         varchar(200)         null,
   itemContent          varchar(800)         not null,
   constraint PK_TBLWORKEVALUATION primary key nonclustered (evaluationId),
   constraint PK_TBLWORKEVALUATION_STATE check (conditions  in ('0','1'))
)
go

alter table tblDepartment
   add constraint FK_TBLDEPAR_REFERENCE_TBLEMPL_bumenyuanggong foreign key (employeeId)
      references tblEmployee (employeeId)
go

alter table tblEmployee
   add constraint FK_TBLDEPAR_REFERENCE_TBLEMPL_bumenyuanggong1 foreign key (departmentId)
      references tblDepartment (departmentId)
go

alter table tblEmployeeAttendanceRecord
   add constraint FK_TBLEMPLO_REFERENCE_TBLEMPLO_yuanggongtokaoqing foreign key (employeeId)
      references tblEmployee (employeeId)
go

alter table tblEmployeeAttendanceRecord
   add constraint FK_TBLEMPLO_REFERENCE_TBLEMPL_yuangongtokaoqing1 foreign key (recordId)
      references tblEmployee (employeeId)
go

alter table tblEmployeeLeave
   add constraint FK_TBLEMPLO_REFERENCE_TBLEMPLO foreign key (auditorId)
      references tblEmployee (employeeId)
go

alter table tblEmployeeLeave
   add constraint FK_TBLEMPLO_REFERENCE_TBLEMPL_yuanggongtoqingjia foreign key (employeeId)
      references tblEmployee (employeeId)
go

alter table tblEmployeeSalary
   add constraint FK_TBLEMPLO_REFERENCE_TBLEMPL_yuanggongxinzhi foreign key (employeeId)
      references tblEmployee (employeeId)
go

alter table tblOvertime
   add constraint FK_TBLOVERT_REFERENCE_TBLEMPL_yuanggongjiaban foreign key (employeeId)
      references tblEmployee (employeeId)
go

alter table tblOvertime
   add constraint FK_TBLOVERT_REFERENCE_TBLOVERT_jiabanleixintojiaban foreign key (overtimeType)
      references tblOvertimeType (overtimeType)
go

alter table tblOvertime
   add constraint FK_TBLOVERT_REFERENCE_TBLEMPL_yuanggongjiaban1 foreign key (evalutorId)
      references tblEmployee (employeeId)
go

alter table tblWorkEvaluation
   add constraint FK_TBLWORKE_REFERENCE_TBLEMPL_yuangongyeji1 foreign key (employeeId)
      references tblEmployee (employeeId)
go

alter table tblWorkEvaluation
   add constraint FK_TBLWORKE_REFERENCE_TBLEMPL_yuanggongyeji foreign key (evalutorsId)
      references tblEmployee (employeeId)
go


--视图1

create view View_ShowEmployeeInformation
as 
	SELECT dbo.tblEmployee.employeeId, dbo.tblEmployee.employeeName, dbo.tblEmployee.employeeLoginName, dbo.tblEmployee.employeeEmail, 
	dbo.tblDepartment.departmentName, dbo.tblEmployee.departmentId, dbo.tblEmployee.employeePhone FROM  dbo.tblEmployee INNER JOIN
    dbo.tblDepartment ON dbo.tblEmployee.departmentId = dbo.tblDepartment.departmentId AND dbo.tblEmployee.employeeId = dbo.tblDepartment.employeeId
               
go

--视图2*

create view View_ShowAttendanceInformation
as 
	SELECT     dbo.tblEmployeeAttendanceRecord.attendanceId, dbo.tblEmployee.employeeName, dbo.tblEmployeeAttendanceRecord.dateTimes, dbo.tblEmployeeAttendanceRecord.attendanceType
FROM         dbo.tblEmployeeAttendanceRecord INNER JOIN
                      dbo.tblEmployee ON dbo.tblEmployeeAttendanceRecord.employeeId = dbo.tblEmployee.employeeId 
		
go

--视图3

create view View_ShowLeaveInformation
as 
	SELECT dbo.tblEmployeeLeave.leaveId, dbo.tblEmployee.employeeName, dbo.tblEmployeeLeave.handTime, dbo.tblEmployeeLeave.reason,
	dbo.tblEmployeeLeave.applytStatus, dbo.tblEmployeeLeave.reasonOfRefuse FROM  dbo.tblEmployeeLeave INNER JOIN dbo.tblEmployee ON
    dbo.tblEmployeeLeave.employeeId = dbo.tblEmployee.employeeId

go


--视图4*

create view View_ShowOvertimeInformation
as 
	SELECT dbo.tblOvertime.applyId, dbo.tblEmployee.employeeName, dbo.tblOvertime.submitTime, dbo.tblOvertime.overtimeReason,
	dbo.tblOvertime.applyConditions, dbo.tblOvertimeType.overtimeName FROM  dbo.tblOvertime INNER JOIN dbo.tblOvertimeType ON
	dbo.tblOvertime.overtimeType = dbo.tblOvertimeType.overtimeType INNER JOIN dbo.tblEmployee ON dbo.tblOvertime.employeeId =
	 dbo.tblEmployee.employeeId 
              
go

--视图5*
create view View_ShowBaseSalaryInformation
as
	 SELECT employeeId, employeeName, employeeBaseSalary
	 FROM  dbo.tblEmployee

go



--部门数据
insert into tblDepartment(departmentName,departmentDescribe)
values('人事部','进行人员调动管理'),
('财务部','公司财政管理'),
('行政部','行政管理'),
('研发部','项目研究开发'),
('销售部','产品销售'),
('公关部','公司推广');

go
--人员数据
insert into tblEmployee(employeeName,employeeLoginName,employeeLoginPwd,employeeEmail,departmentId,employeeBaseSalary,employeePosition,
employeePhone,employeeDataOfArrive,employeeSelfInteroduction,employeeResidueVacations,employeeRank)
values('张一','yizhang','2016100','2016@01',1,8000,'经理','13648577556','2014-1-1','嘿',4,1),
('张二','erzhang','2016101','2016@02',1,4500,'组长','13748897256','2014-7-5','哈',8,2),
('张三','sanzhang','2016102','2016@03',1,4600,'员工','15745842256','2015-6-25','呵',6,3),
('李四','sili','2016103','2016@04',2,8000,'经理','18745847256','2013-2-21','嘿嘿',5,1),
('李五','wuli','2016104','2016@05',2,4400,'组长','15346837856','2012-9-21','哈哈',3,2),
('李六','liuli','2016105','2016@06',2,4700,'员工','13446837526','2015-1-15','呵呵',7,3),
('赵七','qizhao','2016106','2016@07',3,8000,'经理','13244682956','2012-4-21','嘿嘿嘿',2,1),
('赵八','bazhao','2016107','2016@08',3,4800,'组长','15945835256','2014-9-28','哈哈哈',1,2),
('赵九','jiuzhao','2016108','2016@09',3,4100,'员工','16815942656','2016-2-11','呵呵呵',0,3),
('孙十','shisun','2016109','2016@10',4,8100,'经理','14648249566','2013-3-1','嘿！',5,1),
('孙十一','yishisun','2016110','2016@11',4,4300,'组长','13748897256','2014-7-5','哈！',2,2),
('孙十二','ershisun','2016111','2016@12',4,4200,'员工','14945842635','2015-7-25','呵！',4,3),
('钱十三','sanshiqian','2016112','2016@13',5,8300,'经理','17745825161','2012-5-20','嘿嘿！',4,1),
('钱十四','sishiqian','2016113','2016@14',5,4900,'组长','13346837452','2014-9-24','哈哈！',4,2),
('钱十五','wushiqian','2016114','2016@15',5,4300,'员工','1526836257','2015-6-15','呵呵！',1,3),
('周十六','liushizhou','2016115','2016@16',6,8000,'经理','13956244682','2012-2-23','嘿嘿嘿！',3,1),
('周十七','qishizhou','2016116','2016@17',6,4600,'组长','15835594256','2013-8-28','哈哈哈！',5,2),
('周十八','bashizhou','2016117','2016@18',6,4100,'员工','16815942656','2016-4-12','呵呵呵！',7,3)

go
--经理设置
update tblDepartment
set employeeId =(select employeeId from tblEmployee where employeePosition = '经理' and departmentId = 1)
where tblDepartment.departmentName = '人事部' 
go

update tblDepartment
set employeeId =(select employeeId from tblEmployee where employeePosition = '经理' and departmentId = 2)
where tblDepartment.departmentName = '财务部'
go

update tblDepartment
set employeeId =(select employeeId from tblEmployee where employeePosition = '经理' and departmentId = 3)
where tblDepartment.departmentName = '行政部' 
go

update tblDepartment
set employeeId =(select employeeId from tblEmployee where employeePosition = '经理' and departmentId = 4)
where tblDepartment.departmentName = '研发部' 
go

update tblDepartment
set employeeId =(select employeeId from tblEmployee where employeePosition = '经理' and departmentId = 5)
where tblDepartment.departmentName = '销售部' 
go

update tblDepartment
set  employeeId =(select employeeId from tblEmployee where employeePosition = '经理' and departmentId = 6)
where tblDepartment.departmentName = '公关部' 
go

--考勤记录表初始数据
insert into tblEmployeeAttendanceRecord(employeeId,recordId,arriveTime,attendanceType,dateTimes)
values('8','2','2016-05-21 8:33','迟到','2016-05-21')
go

insert into tblEmployeeAttendanceRecord(employeeId,recordId,arriveTime,attendanceType,dateTimes)
values('7','2','2016-05-27 8:27','早退','2016-05-27')
go

insert into tblEmployeeAttendanceRecord(employeeId,recordId,arriveTime,attendanceType,dateTimes)
values('6','3','2016-05-29 8:40','迟到','2016-05-29')
go

insert into tblEmployeeAttendanceRecord(employeeId,recordId,attendanceType,dateTimes)
values('17','3','缺勤','2016-05-17')
go

insert into tblEmployeeAttendanceRecord(employeeId,recordId,attendanceType,dateTimes)
values('12','3','缺勤','2016-05-18')
go


--请假表初始数据

insert into tblEmployeeLeave(employeeId,handTime,stratTime,endTime,reason,timeHours,applytStatus,auditorId)
values('2','2016-06-12','2016-06-13','2016-06-14','看牙医','24','已批准',1)
go

insert into tblEmployeeLeave(employeeId,handTime,stratTime,endTime,reason,timeHours,applytStatus,auditorId)
values('7','2016-06-18','2016-06-19','2016-06-25','回老家结婚','168','已批准',1)
go

insert into tblEmployeeLeave(employeeId,handTime,stratTime,endTime,timeHours,applytStatus,auditorId,reasonOfRefuse)
values('5','2016-06-21','2016-06-22','2016-06-23','24','已否决',1,'无详细请假理由')
go

insert into tblEmployeeLeave(employeeId,handTime,stratTime,endTime,reason,timeHours,applytStatus,auditorId)
values('8','2016-06-24','2016-06-25','2016-06-27','探病','48','已取消',2)
go

insert into tblEmployeeLeave(employeeId,handTime,stratTime,endTime,reason,timeHours,applytStatus,auditorId)
values('7','2016-06-28','2016-06-29','2016-06-30','感冒发烧','24','已批准',2)
go



--加班类型初始数据
insert into tblOvertimeType(overtimeName)
values('折算成津贴')
go

insert into tblOvertimeType(overtimeName)
values('折算年假')
go



--加班表初始数据
insert into tblOvertime(employeeId,submitTime,beginTime,endTime,overtimeReason,applyConditions,overtimeType,timeTours)
values('12','2016-06-1','2016-06-2 17:00','2016-06-2 20:00','赶项目进度','已批准',1,'3')
go

insert into tblOvertime(employeeId,submitTime,beginTime,endTime,overtimeReason,applyConditions,overtimeType,timeTours)
values('2','2016-06-7','2016-06-8 18:00','2016-06-8 20:00','人员不足','已批准',1,'2')
go

insert into tblOvertime(employeeId,submitTime,beginTime,endTime,overtimeReason,applyConditions,overtimeType,timeTours)
values('17','2016-06-9','2016-06-2 17:00','2016-06-2 21:00','出差前加进任务进度','已批准',1,'4')
go

----薪资表初始数据

insert into tblEmployeeSalary(employeeId,payfoDate,cutOfAbsenteeism,baseSalary)
values('7','2016-06-1','10','8000')
go

insert into tblEmployeeSalary(employeeId,payfoDate,cutOfAbsenteeism,baseSalary)
values('12','2016-06-1','100','4200')
go

insert into tblEmployeeSalary(employeeId,payfoDate,cutOfAbsenteeism,baseSalary)
values('17','2016-06-1','100','4600')
go

--假期表初始数据

insert into tblVacation(vacationTime,vacationName,ifNationalVacation)
values('2016-1-1','元旦','1')
go

insert into tblVacation(vacationTime,vacationName,ifNationalVacation)
values('2016-5-1','劳动节','1')
go


