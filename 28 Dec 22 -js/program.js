console.log(`hello world`);
console.log(`hello`, `world`);

// value given with comma will have space between .

console.clear();
// to clear the console

let v = 5;
console.log(v);
// variable initalised with let cannot be redefined.

var firstName = `John`;
var lastName = `Doe`;
console.log(firstName, lastName);
// use camelCasing

console.log(typeof firstName);
// typeof is used to know type of type of variable.

var data = `This is a string`;
console.log(data[1]);
// data[1] is used to access character at position 1.

console.log(data.length);
// data.length is used to get length of string.

console.log(data[data.length - 1]);
// data[data.length-1] is used to get last element of the string.

console.log(data.toUpperCase());
// data.toUpperCase(),data.toLowerCase() is used to convert string to uppercase and lowercase respectively, a copy of string.
// will be converted to uppercase and printed.

// inorder to change the string permenantly we can use.
data = data.toUpperCase();

var info = `        JS FOR WEB  `;
console.log(info);
// message will be printed in console with a space on the left side of the screen.
// inorder to avoid the space in message we can use.
console.log(info.trim());

const splitExample = `HELLO WEB  `;
console.log(splitExample.split());

var res = splitExample.replaceAll(` `, `_`);
console.log(res);
// replace is used to replace first occurance of space with other given character.

res = splitExample
      .toUpperCase()
      .trim()
      .replace(` `, `_`);

console.log(res);


for( let i = 0; i < 6; i++){
    console.log(`inside loop: `, i);
}

// console.log("outside loop: ", i);.
// let have block scope so it gives error.
// var in javascript has global scope instead we can use let or const for variable.

// const Name= 'gk';.
// Name = 'PHP';.
// console.log(Name);.
// above code will give error because const is written 2 times --[Assignment to constant variable]..
// values which are not changed are written in const keyword.

let dataProperty;
console.log(dataProperty);
// it will give undefined value error,which means variable is initalised but no value is provided.
 
// we can use back-tick for multi lined strings.

