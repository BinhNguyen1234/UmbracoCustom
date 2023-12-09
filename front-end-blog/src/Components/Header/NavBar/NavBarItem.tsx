"use client"
import Link from "next/link"

interface PropsNavBarItem {
    name: string,
    url: string
}
export default function NavBarItem({ ...props }: PropsNavBarItem) {
    return (
        <>
            <li className="p6 md:p-2 hover:cursor-pointer">
                <Link href={props.url}>
                    {props.name}
                </Link>
            </li>
        </>
    )
}