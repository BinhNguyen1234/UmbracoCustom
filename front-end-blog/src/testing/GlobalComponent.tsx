import type { Metadata } from "next"
import { Inter } from "next/font/google"
import "./globals.css"

const inter = Inter({ subsets: ["latin"] })
interface Props {
    children: JSX.Element
}

export default function GlobalComponent({ children }: Props) {
    return (
                <div className="fff">{children}</div>
    );
}
