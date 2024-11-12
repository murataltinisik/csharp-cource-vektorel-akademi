create table if not exists "Friends"
(
	"Id" integer generated always as identity,
	"UserId" integer not null,
	"FriendId" integer not null,
	"Status" bit default '0'::"bit" not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_userfriends
		foreign key ("UserId") references "Users",
	constraint fk_friends
		foreign key ("FriendId") references "Users"
);

