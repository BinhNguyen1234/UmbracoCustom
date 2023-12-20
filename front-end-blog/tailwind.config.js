/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./src/**/*.{js,jsx,ts,tsx}"],
    theme: {
        extend: {
            rotate: {
                360: "360deg",
            },
        },
        fontFamily: {},
        colors: {
            black: "#090D1F",
            white: "#FFF",
        },
    },
    plugins: [],
    darkMode: "class",
};
