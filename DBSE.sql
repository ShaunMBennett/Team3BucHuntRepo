/*****************************************************
File name: DBSE.sql
Created By: Philip Gaver & Tanner Collins
Creation Date: 11/16/2022
Last Modified: 11/16/2022
Summary: Create and populate Tasks table for BucHunt
*****************************************************/

-- Drop existing table
DROP TABLE Tasks;

-- Create table to contain task info (TaskID, Location, Question, Answer)
CREATE TABLE Tasks
(
	TaskID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Location varchar(50),
	Question varchar(200),
	Answer varchar(25)
);

-- Insert task 1
INSERT INTO Tasks (Location, Question, Answer)
	VALUES ('Flagpoles next to Brooks Gym (Memorial Hall)', 
			'When was the leadership and excellence memorial for our fallen soldier students dedicated?', 
			'November 11, 2003');

-- Insert task 2
INSERT INTO Tasks (Location, Question, Answer)
	VALUES ('Sam Wilson Hall', 
			'Who is listed on the bench outside the front of Sam Wilson Hall?', 
			'Douglas Dotterweich');


-- Insert task 3
INSERT INTO Tasks (Location, Question, Answer)
	VALUES ('ETSU Book Store', 
			'How many visible pillars are in the ETSU Book Store?', 
			'3');

-- Insert task 4
INSERT INTO Tasks (Location, Question, Answer)
	VALUES ('Special Services Lab', 
			'What room number is the Special Services Lab in Sherrod Library?', 
			'318');

-- Insert task 5
INSERT INTO Tasks (Location, Question, Answer)
	VALUES ('Sherrod Library', 
			'How many printers are available to students on the first floor of the Sherrod Library?', 
			'5');

-- Insert task 6
INSERT INTO Tasks (Location, Question, Answer)
	VALUES ('Brown Hall', 
			'Who is the third author of the paper posted on the wall on the fourth floor of Brown Hall called "Purification and Characterization of Bioactive Metabolites?"', 
			'Sean Fox');

-- Insert task 7
INSERT INTO Tasks (Location, Question, Answer)
	VALUES ('Tri-Hall Field', 
			'How many swings are located within Tri-Hall field?', 
			'4');

-- Insert task 8
INSERT INTO Tasks (Location, Question, Answer)
	VALUES ('Counseling Center', 
			'What room number is the counseling center in the Culp Center?', 
			'326');

-- Insert task 9
INSERT INTO Tasks (Location, Question, Answer)
	VALUES ('Culp Center', 
			'How many restaurants are in the Culp Center?', 
			'5');

-- Insert task 10
INSERT INTO Tasks (Location, Question, Answer)
	VALUES ('ETSU Health Clinic', 
			'What floor is the health clinic located in Roy S. Nicks Halls?', 
			'1');

-- Test to ensure all tasks are in table
-- SELECT * FROM Tasks;

