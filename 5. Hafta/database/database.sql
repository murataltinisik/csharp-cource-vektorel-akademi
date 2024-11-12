create table if not exists "Users"
(
	"Id" integer generated always as identity,
	"Name" varchar(30) not null,
	"Surname" varchar(30) not null,
	"Email" varchar(120) not null,
	"Password" varchar(255) not null,
	"LoginStatus" bit default '0'::"bit",
	"CreatedAt" date default now(),
	"UpdatedAt" date default now(),
	"DeletedAt" date,
	primary key ("Id")
);

create table if not exists "Categories"
(
	"Id" integer generated always as identity,
	"Title" varchar(50) not null,
	"Description" varchar(120) not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id")
);

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

create table if not exists "Groups"
(
	"Id" integer generated always as identity,
	"Title" varchar(50) not null,
	"Description" varchar(255) not null,
	"Image" varchar(255) not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id")
);

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

create table if not exists "Notifications"
(
	"Id" integer generated always as identity,
	"UserId" integer not null,
	"Content" varchar(300),
	"IsRead" bit default '0'::"bit" not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_usernotification
		foreign key ("UserId") references "Users"
);

create table if not exists "Hashtags"
(
	"Id" integer generated always as identity,
	"Tag" varchar not null,
	"Description" varchar(255) not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id")
);

create table if not exists "PostsHashtags"
(
	"Id" integer generated always as identity,
	"PostId" integer generated always as identity,
	"HashtagId" integer generated always as identity,
	primary key ("Id"),
	constraint fk_postshashtags
		foreign key ("PostId") references "Posts",
	constraint fk_postshashtags2
		foreign key ("HashtagId") references "Hashtags"
);

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

create table if not exists "Logs"
(
	"Id" integer generated always as identity,
	"UserId" integer not null,
	"Action" varchar not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_userlogs
		foreign key ("UserId") references "Users"
);

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

create table if not exists "SearchHistory"
(
	"Id" integer generated always as identity,
	"UserId" bigint not null,
	"Content" varchar(200) not null,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id"),
	constraint fk_usersearchhistory
		foreign key ("UserId") references "Users"
);

create table if not exists "APIKeys"
(
	"Id" integer generated always as identity,
	"Key" varchar(36) not null,
	"ExpiryAt" date,
	"CreatedAt" date default CURRENT_TIMESTAMP,
	"UpdatedAt" date default CURRENT_TIMESTAMP,
	"DeletedAt" date,
	primary key ("Id")
);

