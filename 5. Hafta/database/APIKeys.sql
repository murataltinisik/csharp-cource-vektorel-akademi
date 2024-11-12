create table if not exists "APIKeys"
(
	"Id" integer generated always as identity,
	"Key" varchar(36) not null,
	"ExpiryAt" date,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id")
);

