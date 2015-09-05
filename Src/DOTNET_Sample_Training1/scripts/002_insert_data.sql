-- dbdeploy will wrap the application of each change script
-- in a transaction
--
-- DML statements (INSERT, UPDATE etc) can be applied transactionally,
-- so therefore dbdeploy will ensure that either the whole of this script applies
-- or none of it does.
--
INSERT INTO Test VALUES (7, 'This is simple text');
INSERT INTO Test VALUES (8, 'Some UTF-8 chars: åßéá');
INSERT INTO Test VALUES (9, 'This is simple text');
INSERT INTO Test VALUES (11, 'Some UTF-8 chars: åßéá');


