create table if not exists "SearchHistory"
(
	"Id" integer generated always as identity,
	"UserId" bigint not null,
	"Content" varchar(200) not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_usersearchhistory
		foreign key ("UserId") references "Users"
);

