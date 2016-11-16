Product（所有物品）id,name,price,detail,tag,image
content（展示物品）id,name,price,detail,tag,image
person （用户表）id,name,password,type,detail,tele,QQ,image
trx    （交易表）uid, pid,buyPrice, time

create table person(
id int primary key identity(1,1),
name varchar(50) not null,
password varchar(100) not null,
usertype tinyint not null comment"0为买家，1为卖家",
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