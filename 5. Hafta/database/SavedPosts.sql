create table if not exists "SavedPosts"
(
	"Id" integer generated always as identity,
	"UserId" integer not null,
	"PostId" integer not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_usersavedpost
		foreign key ("UserId") references "Users",
	constraint fk_savedpost
		foreign key ("PostId") references "Posts"
);

