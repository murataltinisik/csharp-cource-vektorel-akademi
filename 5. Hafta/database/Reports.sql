create table if not exists "Reports"
(
	"Id" integer generated always as identity,
	"PostId" integer not null,
	"ReporterId" integer not null,
	"ReportedUserId" integer not null,
	"Subject" varchar(50) not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_postreports
		foreign key ("PostId") references "Posts",
	constraint fk_reporterreports
		foreign key ("ReporterId") references "Users",
	constraint fk_reporteduserreports
		foreign key ("ReportedUserId") references "Users"
);

