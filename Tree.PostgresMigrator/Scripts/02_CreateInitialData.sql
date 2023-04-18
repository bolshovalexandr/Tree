INSERT INTO public."Nodes"("NodeId", "Parent", "TreePath", "Title") VALUES(1, null, '1', 'Root');
INSERT INTO public."Nodes"("NodeId", "Parent", "TreePath", "Title") VALUES(2, 1, '1.1', 'Child1-1');
INSERT INTO public."Nodes"("NodeId", "Parent", "TreePath", "Title") VALUES(3, 1, '1.2', 'Child1-2');
INSERT INTO public."Nodes"("NodeId", "Parent", "TreePath", "Title") VALUES(4, 1, '1.3', 'Child1-3');
INSERT INTO public."Nodes"("NodeId", "Parent", "TreePath", "Title") VALUES(5, 1, '1.4', 'Child1-4');

INSERT INTO public."Genres"("Title") VALUES('Progressive');
INSERT INTO public."Genres"("Title") VALUES('Modern');
INSERT INTO public."Genres"("Title") VALUES('Power');