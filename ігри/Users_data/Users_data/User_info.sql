CREATE TABLE User_name (
    User_id INT AUTO_INCREMENT PRIMARY KEY,
    User_name VARCHAR(50) NOT NULL UNIQUE,
    User_password VARCHAR(255) NOT NULL,
    User_achievements TEXT
);
