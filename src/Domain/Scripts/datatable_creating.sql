CREATE TABLE users (
	id int8 PRIMARY KEY NOT NULL GENERATED ALWAYS AS IDENTITY,
	user_name varchar(100) NOT NULL,
	email varchar(200) NOT NULL,
	password VARCHAR(32) NOT NULL,
	badge_id int2 NOT NULL,
	role_id int2 NOT NULL,
	created_at date
)

CREATE TABLE categories (
	id int2 PRIMARY KEY NOT NULL GENERATED ALWAYS AS IDENTITY,
	name varchar(400) NOT NULL,
	slug varchar(100) NOT NULL,
	created_at date
)

CREATE TABLE languages (
	id int2 PRIMARY KEY NOT NULL GENERATED ALWAYS AS IDENTITY,
	name varchar(100) NOT NULL,
	slug varchar(100) NOT NULL,
	created_at date
)

CREATE TABLE problems (
	id int8 PRIMARY KEY NOT NULL GENERATED ALWAYS AS IDENTITY,
	categori_id int2 NOT NULL,
	title varchar(400),
	description VARCHAR(5000),
	is_private bool,
	point FLOAT,
	created_at date,
	CONSTRAINT fk_categori
      FOREIGN KEY(categori_id) 
	  REFERENCES categories(id)
)


CREATE TABLE scripted_Problems (
	id int8 PRIMARY KEY NOT NULL GENERATED ALWAYS AS IDENTITY,
	problem_id int8 NOT NULL,
	language_id int2 NOT NULL,
	created_at date,
	CONSTRAINT fk_problem
      FOREIGN KEY(problem_id) 
	  REFERENCES problems(id),
	CONSTRAINT fk_language
      FOREIGN KEY(language_id) 
	  REFERENCES languages(id)
)

CREATE TABLE user_Solutions (
	id int8 PRIMARY KEY NOT NULL GENERATED ALWAYS AS IDENTITY,
	user_id int8 NOT NULL,
	solution_path varchar(1000),
	score FLOAT,
	created_at date,
	CONSTRAINT fk_user
      FOREIGN KEY(user_id) 
	  REFERENCES users(id)
)

CREATE TABLE problem_Solutions (
	id int8 PRIMARY KEY NOT NULL GENERATED ALWAYS AS IDENTITY,
	user_solution_id int8 NOT NULL,
	problem_id int8 NOT NULL,
	created_at date,
	CONSTRAINT fk_userSolution
      FOREIGN KEY(user_solution_id) 
	  REFERENCES user_solutions(id),
	CONSTRAINT fk_problem
      FOREIGN KEY(problem_id) 
	  REFERENCES problems(id)
)