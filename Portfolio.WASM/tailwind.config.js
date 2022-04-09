const colors = require('tailwindcss/colors');
module.exports = {
    content: [
        './**/*.html',
        './**/*.razor',
        './**/*.cshtml',
    ],
    theme: {
        extend: {
            colors: {
                'white': '#FFFFFF',
                'white1': '#f2f2f2',
                'white2': '#e6e6e6',
                'grey': '#181A1B',
                'grey1': '#242627',
                'grey2': '#2f3132',
                'black1': '#262626',
                'black2': '#313131',
                'black': '#000000',
            }
        },
    },
    plugins: [],
}