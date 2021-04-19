import { Meta, Story } from "@storybook/react/types-6-0";
import AddUser from "../components/AddUser";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/AddUser",
    decorators: [StoryRouter()],
    components: AddUser,
} as Meta;

const Template: Story = () => <AddUser />;

export const Default = Template.bind({});