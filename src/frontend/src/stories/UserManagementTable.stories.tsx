import { Meta, Story } from "@storybook/react/types-6-0";
import UserManagementTable from "../components/UserManagementTable";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/UserManagementTable",
    decorators: [StoryRouter()],
    components: UserManagementTable,
} as Meta;

const Template: Story = () => <UserManagementTable />;

export const Default = Template.bind({});