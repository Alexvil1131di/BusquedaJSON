grammar JSONSearcher;

parse: expr EOF;

expr: ID                                                #parent
    | expr DOT ID                                       #child
    | expr LBRACK op=(INT | FIRST | LAST) RBRACK        #childAttribute
    ;

FIRST: 'first';
LAST: 'last';
ID: [a-zA-Z_][a-zA-Z0-9_]*;
DOT: '.';
LBRACK: '[';
RBRACK: ']';
INT: [0-9]+;
WS: [ \t\r\n]+ -> skip;