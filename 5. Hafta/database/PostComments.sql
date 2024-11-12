create table if not exists "PostComments"
(
	"Id" integer generated always as identity,
	"PostId" integer not null,
	"UserId" integer not null,
	"Content" varchar(300) not null,
	"CreatedAt" date default now(),
	"UpdatedAt" date default now(),
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_postusercomments
		foreign key ("UserId") references "Users",
	constraint fk_postcomments
		foreign key ("PostId") references "Posts"
);

