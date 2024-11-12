create table if not exists "Posts"
(
	"Id" integer generated always as identity,
	"Title" varchar(70) not null,
	"Description" varchar not null,
	"Image" varchar(250) not null,
	"CreatedAt" date default now(),
	"UpdatedAt" date default now(),
	"DeletedAt" date,
	"UserId" integer not null,
	"CategoryId" integer not null,
	primary key ("Id"),
	constraint fk_user
		foreign key ("UserId") references "Users",
	constraint fk_postcategory
		foreign key ("CategoryId") references "Categories"
);

