create table if not exists "Messages"
(
	"Id" integer generated always as identity,
	"SenderId" integer not null,
	"ReceiverId" integer not null,
	"Content" varchar(500) not null,
	"IsRead" bit default '0'::"bit" not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_sendermessages
		foreign key ("SenderId") references "Users",
	constraint fk_receivermessages
		foreign key ("ReceiverId") references "Users"
);

