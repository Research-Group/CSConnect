class Hello extends React.Component {
    render() {
        return <div>
            <h1>{this.props.name}</h1>
            <p>{this.props.subname}</p>
        </div>;
    }
}

/*class Avatar extends Component {
    render() {
        return (
            <img src={`${this.props.file}`} />
        );
    }
}*/