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

