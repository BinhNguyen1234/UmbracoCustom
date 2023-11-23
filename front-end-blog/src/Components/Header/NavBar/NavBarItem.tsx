import Link from "next/link"

interface PropsNavBarItem {
    text: string,
    href: string
}
let style = "p6 md:p-2"
export default function NavBarItem({ ...props }: PropsNavBarItem) {
    return (
        <>
            <li className={style}>
                <Link href={props.href}>
                    {props.text}
                </Link>
            </li>
        </>
    )
}