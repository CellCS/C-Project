Product��������Ʒ��id,name,price,detail,tag,image
content��չʾ��Ʒ��id,name,price,detail,tag,image
person ���û���id,name,password,type,detail,tele,QQ,image
trx    �����ױ�uid, pid,buyPrice, time

create table person(
id int primary key identity(1,1),
name varchar(50) not null,
password varchar(100) not null,
usertype tinyint not null comment"0Ϊ��ң�1Ϊ����",
detail varchar(200),
QQNum varchar(15),
tele varchar(11) not null,
image varchar(200)
);

create table Product(
id int primary key identity(1,1),
name varchar(50) not null,
price int not null,
detail varchar(200),
tag varchar(30) not null,
image varchar(200)
);



create table content(
id int primary key identity(1,1),
name varchar(50) not null,
price int not null,
detail varchar(200),
tag varchar(30) not null,
image varchar(200)
);

create table trx(
id int primary key indentity(1,1),
userId int not null,
productId int not null,
buyPrice int not null,
time bigint not null
);