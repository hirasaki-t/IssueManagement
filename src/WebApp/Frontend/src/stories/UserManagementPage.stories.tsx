import { Meta, Story } from "@storybook/react/types-6-0";
import UserManagementPage from "../pages/UserManagementPage";
import StoryRouter from 'storybook-react-router';

export default {
    title: "pages/UserManagementPage",
    decorators: [StoryRouter()],
    components: UserManagementPage,
} as Meta;

const Template: Story = () => <UserManagementPage />;

export const Default = Template.bind({});