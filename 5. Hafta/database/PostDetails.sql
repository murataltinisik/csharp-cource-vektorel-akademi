create table if not exists "PostDetails"
(
	"PostId" integer not null,
	"UserId" integer not null,
	"Type" integer not null,
	"CreatedAt" timestamp default CURRENT_TIMESTAMP,
	"UpdatedAt" timestamp default CURRENT_TIMESTAMP,
	"DeletedAt" timestamp default CURRENT_TIMESTAMP,
	"Id" integer generated always as identity,
	primary key ("Id"),
	constraint fk_postdetails
		foreign key ("PostId") references "Posts",
	constraint fk_postuserdetails
		foreign key ("UserId") references "Users"
);

