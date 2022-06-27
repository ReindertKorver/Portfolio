const colors = require('tailwindcss/colors');
module.exports = {
    darkMode: 'class',
    content: [
        './**/*.html',
        './**/*.razor',
        './**/*.cshtml',
    ],
    theme: {
        extend: {
            colors: {
                'white': '#FFFFFF',
                'white1': '#f9f9f9',
                'white2': '#f2f2f2',
                'white2': '#e6e6e6',
                'grey': '#181A1B',
                'grey1': '#242627',
                'grey2': '#2f3132',
                'grey3': '#3b3e3f',
                'black1': '#262626',
                'black2': '#313131',
                'black': '#000000',
            }
        },
    },
    plugins: [],
}