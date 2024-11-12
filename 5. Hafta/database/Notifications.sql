create table if not exists "Notifications"
(
	"Id" integer generated always as identity,
	"UserId" integer not null,
	"Content" varchar(300),
	"IsRead" bit default '0'::"bit" not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_usernotification
		foreign key ("UserId") references "Users"
);

