/*00. Create New Database*/
CREATE DATABASE `softuni`;

/*01. Create Table*/
USE `softuni`;
CREATE TABLE `students` (
	`id` int auto_increment primary key,
    `first_name` varchar(50),
    `last_name` varchar(50),
    `age` int,
    `grade` double
);

/*02. Insert Data*/
USE `softuni`;
INSERT INTO `students` (`id`, `first_name`, `last_name`, `age`, `grade`)
VALUES
(1,	'Guy', 'Gilbert', 15, 4.5),
(2,	'Kevin', 'Brown', 17, 5.4),
(3,	'Roberto', 'Tamburello', 19, 6),
(4,	'Linda', 'Smith', 18, 5),
(5,	'John', 'Stones', 16, 4.25),
(6,	'Nicole', 'Nelson', 17, 5.50);

/*03. Find All Records*/
USE `softuni`;
SELECT * FROM `students`;

/*04. Find Last Name, Age and Grade*/
USE `softuni`;
SELECT `last_name`, `age`, `grade` FROM `students`;

/*05. Find First 5 Records*/
USE `softuni`;
SELECT * FROM `students` 
LIMIT 5;

/*06. Find First 5 Last Name and Grade*/
USE `softuni`;
SELECT `last_name`, `grade` FROM `students` 
LIMIT 5;

/*07. Truncate Table*/
USE `softuni`;
Truncate Table `students`;

/*08. Drop Table*/
USE `softuni`;
DROP TABLE `students`;

/*09. Drop Database*/
USE `softuni`;
DROP DATABASE `softuni`;
