hello();
function hello()
{
    console.log('hello world!');
}
// hoisting is the concept which reads code and looks for global variables and then executes the code

function add(x, y) {
    return x + y;
}
console.log(add(20, 30));
//       or
// const res = add(20, 30);
// console.log(res); 

function changeCasing(val){
   return val.toUpperCase();
}
const res = changeCasing('Hello');
console.log(res.toLowerCase());

// function getFirstChar1(value)  // normal function
// {
//     return value[0];
// }

// const getFirstChar2 = function (value) // anonymous function
// {
//     return value[0];
// };

const getFirstChar1 = (value) =>
{
    return value[0];
};

const getCharName = value => value[0];

console.log(getFirstChar1('hello'));
console.log(getCharName('hello'));

const arr = [20,40,60,80,100,12,34,56];
const arr2 = [];
for ( let i = 0; i <= arr.length; i++)
{
    if(arr[i] % 2 === 0)
    {
     arr2.push(arr[i]);
    }
}
    console.log(arr2);

    const num = [1, 2, 3, 4, 5];
    // num.fill(10);
    // fill elements of array with number 10
    console.log(num);

    if(num.includes(5))
    {
        console.log('array contain element 5');
    }
    
    
