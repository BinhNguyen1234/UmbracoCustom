interface THeaderProps {
    children: JSX.Element
}
export default function Header({children}:THeaderProps):JSX.Element{
    return (<>
        {children}
    </>)
}