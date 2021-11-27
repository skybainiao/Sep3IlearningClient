drop schema if exists "sep3data" cascade;
create schema "sep3data";
set schema 'sep3data';


create table SimpleUser(
    username varchar(30),
    password varchar(30),
    receiveMessageNum int,
    primary key (username)
);

create table LecturerAccount(
    lecturerName varchar(30),
    username varchar(30),
    password varchar(30),
    primary key (username)
);

create table Friend(
    username varchar(30),
    friendName varchar(30),
    foreign key (username) references SimpleUser(username)
);

create table Message(
    senderName varchar(30),
    receiveName varchar(30),
    chatMessages varchar(1000),
    foreign key (senderName) references SimpleUser(username),
    foreign key (receiveName) references SimpleUser(username)
);

create table FriendRequest(
    sender varchar(30),
    receiver varchar(30),
    comment varchar(100),
    foreign key (sender) references SimpleUser(username),
    foreign key (receiver) references SimpleUser(username),
    unique (receiver)
);

create table Profile(
    username varchar(30),
    firstName varchar(30),
    lastName varchar(30),
    email varchar(30),
    phoneNumber varchar(30),
    country varchar(30),
    age varchar(30),
    sex varchar(30)

);

insert into SimpleUser(username,password,receiveMessageNum)
values ('Chen','dsajio',0),
       ('Jax','dsajio',0),
       ('Alex','dsajio',0),
       ('Qiyana','dsajio',0),
       ('Ben','dsajio',0);

insert into LecturerAccount(lecturerName, username, password)
values ('John','John','dsajio');

insert into Friend(username, friendName)
values ('Chen','Jax'),
       ('Chen','Alex'),
       ('Chen','Qiyana'),
       ('Jax','Chen');

insert into Message(senderName, receiveName,chatMessages)
values ('Chen','Jax','hello'),
       ('Chen','Jax','world'),
       ('Jax','Chen','helloWorld'),
       ('Alex','Chen','i can do it');

insert into Profile(username, firstName, lastName, email, phoneNumber, country,age,sex)
values ('Chen','Junjie','Chen','chen246883003@gmail.com','52721354','China','20','male'),
       ('Ben','Chenben','Tong','246883003@gmail.com','4324325','China','22','male');

insert into FriendRequest(sender, receiver, comment)
values ('Chen','Ben','accept me'),
       ('Jax','Chen','Hello');


select chatMessages
from Message
where senderName = 'Jax' and receiveName = 'Chen'
or senderName = 'Chen' and receiveName = 'Jax';

select friendName
from Friend
where username = 'Chen';

update SimpleUser set receiveMessageNum = receiveMessageNum+1 where username = 'Chen';

update SimpleUser set receiveMessageNum = 0 where username = 'Chen';

select username
from SimpleUser;

select chatmessages
from Message
where senderName = 'Chen' and receiveName = 'Jax';

select receiveMessageNum
from SimpleUser
where username = 'Chen';

update SimpleUser set receiveMessageNum = 0 where username = 'Chen';

select * from SimpleUser;

select * from LecturerAccount;

select * from Profile;

delete from Profile where username = 'Ben';

select * from FriendRequest where receiver = 'Chen';
