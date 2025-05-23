SELECT cru, millesime
FROM VIN, PRODUCTEUR, ABU, BUVEUR
WHERE PRODUCTEUR.numprod=VIN.numprod
AND VIN.numvin=ABU.numvin
AND ABU.numbuv=BUVEUR.numbuv
AND nombuv = 'Martin' 
AND nomprod = 'Vallet';