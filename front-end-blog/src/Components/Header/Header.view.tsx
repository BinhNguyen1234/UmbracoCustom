interface THeaderProps {
    children: JSX.Element
}
export default function Header({ children }: THeaderProps): JSX.Element{
    return (<>
        <header className="flex justify-between items-center px-[112px]">
            <div className="basis-1/5">
                logo
            </div>
            <div className="">
                {children}
            </div>
        </header>
    </>)
}