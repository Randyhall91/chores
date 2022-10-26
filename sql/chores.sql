-- Active: 1666715464348@@SG-shaded-voice-9071-6836-mysql-master.servers.mongodirector.com@3306@Classroom

CREATE TABLE
    IF NOT EXISTS chores (
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        title VARCHAR(255) NOT NULL,
        priority INT NOT NULL CHECK(priority <= 10),
        IsComplete BOOLEAN NOT NULL,
        OwnerId VARCHAR(255) NOT NULL,
        FOREIGN KEY(OwnerId) REFERENCES accounts(id) ON DELETE CASCADE
    ) DEFAULT charset utf8 COMMENT '';