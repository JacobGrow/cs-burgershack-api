USE burgershack421;


-- Mysql : MongDb -- Table : Collection

-- CREATE COLLECTION
-- CREATE TABLE burgers
-- (
--   id INT AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL UNIQUE,
--   description VARCHAR(255),
--   price DECIMAL(5, 2) NOT NULL,

--   PRIMARY KEY(id)
-- );

-- GET ALL
-- SELECT* FROM burgers;

-- GET BY ID
-- SELECT * FROM burgers WHERE id = 1;

CREATE
INSERT INTO burgers 
( name, price, description)
VALUES
("Big Ol' Burger", 7.99, "Its just a big ol' burger");

-- EDIT
-- UPDATE burgers
-- SET
--   description = "Its extra cheesy!",
--   price = 5.99
-- WHERE id = 4;

-- DELETE
-- DELETE FROM burgers WHERE id = 4;

-- DANGER ZONE
-- DELETE FROM burgers -- DELETES ALL DATA IN TABLE
-- DROP TABLE burgers -- DESTROYS WHOLE TABLE
-- DROP DATABASE burgershack421; -- DESTROYS WHOLE DATABASE;

