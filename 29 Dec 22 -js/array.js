const numbers = [1, 2, 3, 'four'];
console.log(numbers[30]);

const num = [1, 2, 3, '4'];
num[4] = 4;
console.log(num);
// 4th value is not present in array so it will add new element and resize the array

num.push(5);
console.log(num);
// Appends new elements to the end of an array, and returns the new length of the array.

const firstArray = [1, 2, 3];
const secondArray = [4, 5, 6];
firstArray.push(...secondArray);
console.log(firstArray);
// spread operator is used to select all elements inside secondArray and push to firstArray.

const thirdArray = firstArray.concat(secondArray);
console.log(thirdArray);
// concat is used to concat two arrays.

