import { Meta, Story } from "@storybook/react/types-6-0";
import HomePage from "../pages/HomePage";
import StoryRouter from 'storybook-react-router';

export default {
    title: "pages/HomePage",
    decorators: [StoryRouter()],
    components: HomePage,
} as Meta;

const Template: Story = () => <HomePage />;

export const Default = Template.bind({});