"use client";
import ToggleButton from "@/UIComponent/ToggleBtn/ToggleBtn.view";
export default function DarkModeToggleBtn() {
    function switchThemes() {
        document.body.classList.toggle("dark");
    }
    return (
        <>
            <ToggleButton onInput={switchThemes}>
                <>
                    <svg
                        className="!moon hover:rotate-360 duration-700"
                        viewBox="0 0 24 24"
                        fill="none"
                        xmlns="http://www.w3.org/2000/svg"
                    >
                        <g id="SVGRepo_bgCarrier" strokeWidth="0" />

                        <g
                            id="SVGRepo_tracerCarrier"
                            strokeLinecap="round"
                            strokeLinejoin="round"
                        />

                        <g id="SVGRepo_iconCarrier">
                            {" "}
                            <path
                                opacity="0.5"
                                fillRule="evenodd"
                                clipRule="evenodd"
                                d="M22 12.0004C22 17.5232 17.5228 22.0004 12 22.0004C10.8358 22.0004 9.71801 21.8014 8.67887 21.4357C8.24138 20.3772 8 19.217 8 18.0004C8 15.7792 8.80467 13.7459 10.1384 12.1762C11.31 13.8818 13.2744 15.0004 15.5 15.0004C17.8615 15.0004 19.9289 13.741 21.0672 11.8572C21.3065 11.4612 22 11.5377 22 12.0004Z"
                                fill="#ffffff"
                            />{" "}
                            <path
                                d="M2 12C2 16.3586 4.78852 20.0659 8.67887 21.4353C8.24138 20.3768 8 19.2166 8 18C8 15.7788 8.80467 13.7455 10.1384 12.1758C9.42027 11.1303 9 9.86422 9 8.5C9 6.13845 10.2594 4.07105 12.1432 2.93276C12.5392 2.69347 12.4627 2 12 2C6.47715 2 2 6.47715 2 12Z"
                                fill="#ffffff"
                            />{" "}
                        </g>
                    </svg>
                    <svg
                        viewBox="0 0 1024 1024"
                        className="icon !sun hover:rotate-360 duration-700"
                        version="1.1"
                        xmlns="http://www.w3.org/2000/svg"
                    >
                        <path
                            d="M861 656.7l144.6-144.6L861 367.6V163.1H656.6L512 18.6 367.4 163.1H163v204.5L18.4 512.1 163 656.7v204.4h204.4L512 1005.7l144.6-144.6H861z"
                            fill="#FCD170"
                        />
                        <path
                            d="M512 1015.7c-2.6 0-5.1-1-7.1-2.9L363.3 871.1H163c-5.5 0-10-4.5-10-10V660.8L11.4 519.2c-1.9-1.9-2.9-4.4-2.9-7.1 0-2.7 1.1-5.2 2.9-7.1L153 363.4V163.1c0-5.5 4.5-10 10-10h200.3L504.9 11.5c1.9-1.9 4.4-2.9 7.1-2.9s5.2 1.1 7.1 2.9l141.6 141.6H861c5.5 0 10 4.5 10 10v200.3L1012.6 505c1.9 1.9 2.9 4.4 2.9 7.1 0 2.7-1.1 5.2-2.9 7.1L871 660.8v200.3c0 5.5-4.5 10-10 10H660.7l-141.6 141.6c-2 2-4.5 3-7.1 3zM173 851.1h194.4c2.7 0 5.2 1.1 7.1 2.9L512 991.6l137.5-137.5c1.9-1.9 4.4-2.9 7.1-2.9H851V656.7c0-2.7 1.1-5.2 2.9-7.1l137.5-137.5-137.5-137.5c-1.9-1.9-2.9-4.4-2.9-7.1V173.1H656.6c-2.7 0-5.2-1.1-7.1-2.9L512 32.7 374.5 170.2c-1.9 1.9-4.4 2.9-7.1 2.9H173v194.4c0 2.7-1.1 5.2-2.9 7.1L32.6 512.1l137.5 137.5c1.9 1.9 2.9 4.4 2.9 7.1v194.4z"
                            fill=""
                        />
                        <path
                            d="M512 512.1m-257.8 0a257.8 257.8 0 1 0 515.6 0 257.8 257.8 0 1 0-515.6 0Z"
                            fill="#F7DDAD"
                        />
                        <path
                            d="M512 779.9c-71.5 0-138.8-27.9-189.4-78.4-50.6-50.6-78.4-117.8-78.4-189.4s27.9-138.8 78.4-189.4c50.6-50.6 117.8-78.4 189.4-78.4 71.5 0 138.8 27.9 189.4 78.4 50.6 50.6 78.4 117.8 78.4 189.4S752 650.9 701.4 701.5 583.5 779.9 512 779.9z m0-515.6c-66.2 0-128.4 25.8-175.2 72.6-46.8 46.8-72.6 109-72.6 175.2s25.8 128.4 72.6 175.2c46.8 46.8 109 72.6 175.2 72.6 66.2 0 128.4-25.8 175.2-72.6 46.8-46.8 72.6-109 72.6-175.2S734 383.7 687.2 336.9c-46.8-46.8-109-72.6-175.2-72.6z"
                            fill=""
                        />
                    </svg>
                </>
            </ToggleButton>
        </>
    );
}
