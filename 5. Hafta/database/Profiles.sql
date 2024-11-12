create table if not exists "Profiles"
(
	"Id" integer generated always as identity,
	"UserId" integer not null,
	"Biography" varchar(500),
	"Birthdate" date,
	"Job" varchar(30),
	"CityId" integer,
	"CountryId" integer,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	primary key ("Id"),
	constraint fk_userprofiles
		foreign key ("UserId") references "Users"
);

