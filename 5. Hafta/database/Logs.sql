create table if not exists "Logs"
(
	"Id" integer generated always as identity,
	"UserId" integer not null,
	"Action" varchar not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_userlogs
		foreign key ("UserId") references "Users"
);

