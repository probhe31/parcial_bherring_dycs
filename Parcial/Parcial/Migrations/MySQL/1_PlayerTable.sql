CREATE TABLE player(
  player_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
  player_first_name VARCHAR(50) NOT NULL,
  player_last_name VARCHAR(50) NOT NULL,  
  active BIT NOT NULL,
  PRIMARY KEY(player_id),
  INDEX IX_customer_last_first_name(player_last_name, player_first_name) 
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO player(player_first_name, player_last_name, active) 
VALUES
('Pedro', 'Yance', 1),
('Ricardo', 'Ilizarbe', 1),
('Alfredo', 'Tenorio', 1);