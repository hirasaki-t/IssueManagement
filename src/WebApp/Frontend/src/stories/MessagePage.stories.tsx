import { Meta, Story } from "@storybook/react/types-6-0";
import MessagePage from "../pages/MessagePage";
import StoryRouter from 'storybook-react-router';

export default {
    title: "pages/MessagePage",
    decorators: [StoryRouter()],
    components: MessagePage,
} as Meta;

const Template: Story = () => <MessagePage />;

export const Default = Template.bind({});