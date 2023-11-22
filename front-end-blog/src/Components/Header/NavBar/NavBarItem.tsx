import Link from "next/link"

interface PropsNavBarItem {
    text: string,
    href: string
}

export default function NavBarItem({...props}:PropsNavBarItem){
    return (
        <>
            <li>
                <Link href={props.href}>
                    {props.text}
                </Link>
            </li>
        </>
    )
}