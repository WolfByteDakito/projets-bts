SELECT *
FROM BUVEUR, ABU
WHERE BUVEUR.numbuv = ABU.numbuv 
AND BUVEUR.nombuv no exists ;

