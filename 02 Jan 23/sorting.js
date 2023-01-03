

let array = [10,8,34,23,45,90,21]; 

const lengthOfArray = array.length;
for (let i = 0; i < lengthOfArray - 1; i++) {
    for (let j = i + 1; j < lengthOfArray ; j++) {
        if ( array[i] > array[j] )
        {
         let swap = array[i];
         array[i] = array[j];
         array[j] = swap;
        }
    }
}

for (let i = 0; i < lengthOfArray ; i++) {
    const element = array[i];
    console.log(element);
    
}