create table if not exists "BlockedUsers"
(
	"Id" integer generated always as identity,
	"BlockerId" integer not null,
	"BlockedId" integer not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_blokerblockedusers
		foreign key ("BlockerId") references "Users",
	constraint fk_blokedblockedusers
		foreign key ("BlockedId") references "Users"
);

