create table if not exists "GroupMembers"
(
	"Id" integer generated always as identity,
	"GroupId" integer not null,
	"UserId" integer not null,
	"Role" integer not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_groupmembers
		foreign key ("UserId") references "Users",
	constraint fk_groups
		foreign key ("GroupId") references "Groups"
);

