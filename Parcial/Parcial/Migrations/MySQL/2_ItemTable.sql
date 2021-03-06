﻿CREATE TABLE item(
  item_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
  item_name VARCHAR(50) NOT NULL,
  item_description VARCHAR(300) NOT NULL,  
  item_level INT UNSIGNED NOT NULL,      
  cost DECIMAL(10,2) NOT NULL,
  currency VARCHAR(8) NOT NULL,
  PRIMARY KEY(item_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


INSERT INTO item(item_name, item_description, item_level, cost, currency) 
VALUES
('Pergamino de teletransporte', 'Te teletransporta a la estructura aliada objetivo.', 1, 100.00, 'COOPER'),
('Anillo de basilius', ' Otorga regeneración de maná y armadura en un área de 900.', 1, 50.00, 'COOPER'),
('Escudo robusto', 'Te teletransporta a la estructura aliada objetivo.', 2, 200.00, 'COOPER'),
('Guantes de fuerza', '+3 Fuerza.', 2, 500.00, 'COOPER'),
('Mano de midas', 'Mata a un objetivo no héroe a cambio de 200 de oro y 1.85x de experiencia.', 2, 100.00, 'SILVER'),
('Máscara mórbida', ' Cura al atacante un porcentaje del daño de ataque infligido.', 2, 200.00, 'SILVER'),
('Daga de traslación', 'Te teletransporta un máximo de 1200 unidades hasta el punto objetivo..', 2, 250.00, 'SILVER'),
('Martillo de mithril', 'Un martillo forjado con puro mithril, otorga +24 Daño.', 3, 500.00, 'SILVER'),
('Grebas del guardián', 'Uno de los muchos instrumentos sagrados construidos en honor a la Omnisciencia. ', 3, 800.00, 'SILVER'),
('Coraza de asalto', 'Forjada en lo más recóndito de los confines abisales, esta malla infernal proporciona a un ejército una armadura y velocidad de ataque aumentadas.', 3, 100.00, 'SILVER'),
('Guadaña de Vyse', 'La reliquia mejor custodiada en el culto a Vyse, es el arma más codiciada por los magos.', 4, 100.00, 'GOLD'),
('Hoja Abisal', 'La hoja perdida del Comandante del Abismo, este filo atraviesa el alma de un enemigo.', 4, 200.00, 'GOLD'),
('Reliquia Sagrada', 'Una antigua arma que suele cambiar el curso de la batalla.', 4, 300.00, 'GOLD');
