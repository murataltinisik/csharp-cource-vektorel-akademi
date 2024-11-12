create table if not exists "Hashtags"
(
	"Id" integer generated always as identity,
	"Tag" varchar not null,
	"Description" varchar(255) not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id")
);

