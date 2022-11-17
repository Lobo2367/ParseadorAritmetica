grammar aritmetica;
aritmetica: expresion+ EOF;
expresion:
	expresion SUM termino
	| expresion RES termino
	| termino;
termino: termino MUL factor | termino DIV factor | factor;
factor: NUM | LPAR expresion RPAR;
NUM: [0-9]+;
RES: '-';
MUL: '*';
SUM: '+';
DIV: '/';
LPAR: '(';
RPAR: ')';
WS: ' '+ -> skip;