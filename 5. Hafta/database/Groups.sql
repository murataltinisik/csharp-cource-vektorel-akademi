create table if not exists "Groups"
(
	"Id" integer generated always as identity,
	"Title" varchar(50) not null,
	"Description" varchar(255) not null,
	"Image" varchar(255) not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id")
);

