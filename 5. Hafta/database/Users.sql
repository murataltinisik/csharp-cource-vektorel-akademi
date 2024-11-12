create table if not exists "Users"
(
	"Id" integer generated always as identity,
	"Name" varchar(30) not null,
	"Surname" varchar(30) not null,
	"Email" varchar(120) not null,
	"Password" varchar(255) not null,
	"LoginStatus" bit default '0'::"bit",
	"CreatedAt" date default now(),
	"UpdatedAt" date default now(),
	"DeletedAt" date,
	primary key ("Id")
);

