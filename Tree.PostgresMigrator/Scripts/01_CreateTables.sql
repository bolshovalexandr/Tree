CREATE TABLE public."Nodes" (
	"Id" serial4 not null,
	"NodeId" int4 not null,
	"Parent" int4 null,
	"TreePath" text not null,
	"Title" text NULL
);

CREATE TABLE public."Genres" (
	"Id" serial4 not null,
	"Title" text not NULL
);